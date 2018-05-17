using System;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Toolkit.Uwp.Notifications;

namespace OutlookBitrixAddIn
{
    public partial class Ribbon1
    {
        int count = 0;
        Company company = new Company();
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void FindByIdBtn_Click(object sender, RibbonControlEventArgs e)
        {
            if ((enterID.Text.Length > 0) && Int32.TryParse(enterID.Text, out int t))
            {
                company = Globals.ThisAddIn.GetCompanyData(enterID.Text);
                if (!company.isNull)
                {
                    enterID.Text = "";

                    btnLogin.Label = company.Login;
                    btnLogin.Enabled = true;

                    btnPass.Label = company.Password;
                    btnPass.Enabled = true;

                    btnShLogin.Label = company.ShadowLogin;
                    btnShLogin.Enabled = true;

                    btnShPass.Label = company.ShadowPassword;
                    btnShPass.Enabled = true;

                    group2.Label = company.Name + " ID=" + company.ID;
                    phone.Label = company.Phone;
                    director.Label = company.Director;
                    group3.Label = company.Email;

                    manger.Label = "Куратор: " + Globals.ThisAddIn.ManagerName(company.Assigned);

                    sendMail.Enabled = true;
                    sendLogPass.Enabled = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("!!!Такого ID не существует!!!");
                    enterID.Text = "";
                    phone.Label = "                                                 ";
                    director.Label = "                                                 ";

                    btnLogin.Label = " ";
                    btnLogin.Enabled = false;

                    btnPass.Label = " ";
                    btnPass.Enabled = false;

                    btnShLogin.Label = " ";
                    btnShLogin.Enabled = false;

                    btnShPass.Label = " ";
                    btnShPass.Enabled = false;

                    group2.Label = "Учетные данные ТА";
                    group3.Label = " ";

                    sendMail.Enabled = false;
                    sendLogPass.Enabled = false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("В строке ID не цифры");
            }
        }

        private void SendMail_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.SendMail(company.Email);
        }

        private void SendLogPass_Click(object sender, RibbonControlEventArgs e)
        {
            string body = String.Format("Название ТА: {0}\r\n" + "ID: {1}\r\n" + "Логин: {2}\r\n" + "Пароль: {3}\r\n", company.Name, company.ID, company.Login, company.Password);
            Globals.ThisAddIn.SendMail(company.Email, body);
        }

        private void BitrixAuth_Click(object sender, RibbonControlEventArgs e)
        {
            System.Windows.Forms.Form form = new regBitrix();
            form.ShowDialog();
        }

        private void FindByEmailBtn_Click(object sender, RibbonControlEventArgs e)
        {
            company = Globals.ThisAddIn.GetCompanyByMail(findByEmail.Text);
            if (!company.isNull)
            {
                findByEmail.Text = "";

                btnLogin.Label += company.Login;
                btnLogin.Enabled = true;

                btnPass.Label += company.Password;
                btnPass.Enabled = true;

                btnShLogin.Label += company.ShadowLogin;
                btnShLogin.Enabled = true;

                btnShPass.Label += company.ShadowPassword;
                btnShPass.Enabled = true;

                group2.Label = company.Name + " ID=" + company.ID;
                phone.Label = company.Phone;
                director.Label = company.Director;
                group3.Label = company.Email;

                sendMail.Enabled = true;
                sendLogPass.Enabled = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Компании с таким eMail не найдено.");
                findByEmail.Text = "";
                phone.Label = "                                                 ";
                director.Label = "                                                 ";

                btnLogin.Label = " ";
                btnLogin.Enabled = false;

                btnPass.Label = " ";
                btnPass.Enabled = false;

                btnShLogin.Label = " ";
                btnShLogin.Enabled = false;

                btnShPass.Label = " ";
                btnShPass.Enabled = false;

                group2.Label = "Учетные данные ТА";
                group3.Label = " ";

                sendMail.Enabled = false;
                sendLogPass.Enabled = false;
            }
        }

        private void BtnLogin_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonButton button = sender as RibbonButton;
            System.Windows.Forms.Clipboard.SetDataObject(button.Label);
        }

        public void SendMailStatus(string email)
        {
            lastMail.Label = email;
            count++;
            mailCount.Label = count.ToString();
            date.Label = "в " + DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }
            

    }
}
