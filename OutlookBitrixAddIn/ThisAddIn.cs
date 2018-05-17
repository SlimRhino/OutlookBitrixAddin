using System;
using System.Collections.Generic;
using System.Timers;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace OutlookBitrixAddIn
{
    public partial class ThisAddIn
    {
        public string pathToBtrixPass = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Outlook\bitrixdata.blp";
        
        public string[] bitrixAuth = new string[3]; //0 - логин 1, - пароль 2, - номер учетки в системе
        const double interval = 300000;
        string templatePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Шаблоны\CurratorMail.oft";
        Bitrix24 bitrix = new Bitrix24();
        Timer checkForTime = new Timer(interval);

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            /*
            if (!System.IO.File.Exists(pathToBtrixPass))
            {
                System.Windows.Forms.Application.Run(new regBitrix());
            }
            */
            
            if (System.IO.File.Exists(pathToBtrixPass))
            {
                
                bitrixAuth = System.IO.File.ReadAllLines(pathToBtrixPass);
                if (bitrix.Connect(bitrixAuth[0], bitrixAuth[1]))
                {
                    checkForTime.Elapsed += new ElapsedEventHandler(CheckTasks);
                    checkForTime.Enabled = true;
                    Globals.Ribbons.Ribbon1.mag.Visible = true;
                    CheckTasks(null, null);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Fuck");
                }
            }

            
            //bitrix.Connect(bitrixAuth[0], bitrixAuth[1]);

        }

        void CheckTasks(object sender, ElapsedEventArgs e)
        {
            Dictionary<string, Company> tasks = bitrix.GetTasks(bitrixAuth[2]);
            if (tasks != null)
            {
                foreach (KeyValuePair<string, Company> task in tasks)
                {
                    SendMail(task.Value.Email);
                    bitrix.UpdateTask(task.Key);
                    Globals.Ribbons.Ribbon1.SendMailStatus(task.Value.Email);
                }
            }
        }

        
        public void SendMail(string email)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder( Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem eMail = Application.CreateItemFromTemplate(templatePath,folder) as Outlook.MailItem;
            eMail.Subject = "Мастер Агент 2015";
            eMail.To = email;
            eMail.Importance = Outlook.OlImportance.olImportanceNormal;
            eMail.Send();
        }

        public void SendMail(string email, string body)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem eMail = Application.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
            eMail.Body = body;
            eMail.Subject = "Восстановление данных регистрации МА2015";
            eMail.To = email;
            eMail.Importance = Outlook.OlImportance.olImportanceNormal;
            eMail.Send();
        }

        public Company GetCompanyData(string ID)
        {
           return bitrix.GetCompanyById(ID);
        }

        public bool Connect(string login, string password)
        {
            return bitrix.Connect(login, password);
        }

        public bool ManagerExist (string id)
        {
            return bitrix.UserExist(id);
        }

        public string ManagerName(string id)
        {
            return bitrix.UserName(id);
        }

        public Company GetCompanyByMail (string email)
        {
            return bitrix.GetCompanyByEmail(email);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Примечание. Outlook больше не выдает это событие. Если имеется код, который 
            //    должно выполняться при завершении работы Outlook, см. статью на странице https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
