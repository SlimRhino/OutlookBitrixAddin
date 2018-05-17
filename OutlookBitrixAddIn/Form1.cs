using System;

using System.Text;
using System.IO;
using System.Windows.Forms;

namespace OutlookBitrixAddIn
{
    public partial class regBitrix : Form
    {
        public regBitrix()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((password.Text != "") && (login.Text != "") && (manager.Text != ""))
            {
               if(Globals.ThisAddIn.Connect(login.Text, password.Text))
               {
                    if (Globals.ThisAddIn.ManagerExist(manager.Text))
                    {
                        string[] auth = { login.Text, password.Text, manager.Text };
                        File.WriteAllLines(Globals.ThisAddIn.pathToBtrixPass, auth);
                        Globals.Ribbons.Ribbon1.mag.Visible = true;
                        this.Close();
                    }
                    else  MessageBox.Show("Авторизация прошла, но такой пользователь не существует");
                }
                else MessageBox.Show("Авторизация не удалась, проверьте логин и пароль");
                MessageBox.Show("Теперь необходимо перезагрузить Outlook");
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
