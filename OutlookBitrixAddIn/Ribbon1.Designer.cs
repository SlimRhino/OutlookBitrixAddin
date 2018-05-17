namespace OutlookBitrixAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mag = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.label3 = this.Factory.CreateRibbonLabel();
            this.label4 = this.Factory.CreateRibbonLabel();
            this.label5 = this.Factory.CreateRibbonLabel();
            this.enterID = this.Factory.CreateRibbonEditBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.box6 = this.Factory.CreateRibbonBox();
            this.findByEmail = this.Factory.CreateRibbonEditBox();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box2 = this.Factory.CreateRibbonBox();
            this.login = this.Factory.CreateRibbonLabel();
            this.box3 = this.Factory.CreateRibbonBox();
            this.password = this.Factory.CreateRibbonLabel();
            this.director = this.Factory.CreateRibbonLabel();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.box4 = this.Factory.CreateRibbonBox();
            this.shadowlogin = this.Factory.CreateRibbonLabel();
            this.box5 = this.Factory.CreateRibbonBox();
            this.shadowpass = this.Factory.CreateRibbonLabel();
            this.phone = this.Factory.CreateRibbonLabel();
            this.manger = this.Factory.CreateRibbonLabel();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.label6 = this.Factory.CreateRibbonLabel();
            this.label7 = this.Factory.CreateRibbonLabel();
            this.box7 = this.Factory.CreateRibbonBox();
            this.mailCount = this.Factory.CreateRibbonLabel();
            this.box8 = this.Factory.CreateRibbonBox();
            this.lastMail = this.Factory.CreateRibbonLabel();
            this.bitrixAuth = this.Factory.CreateRibbonButton();
            this.findByIdBtn = this.Factory.CreateRibbonButton();
            this.findByEmailBtn = this.Factory.CreateRibbonButton();
            this.btnLogin = this.Factory.CreateRibbonButton();
            this.btnPass = this.Factory.CreateRibbonButton();
            this.btnShLogin = this.Factory.CreateRibbonButton();
            this.btnShPass = this.Factory.CreateRibbonButton();
            this.sendMail = this.Factory.CreateRibbonButton();
            this.sendLogPass = this.Factory.CreateRibbonButton();
            this.date = this.Factory.CreateRibbonLabel();
            this.mag.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.box6.SuspendLayout();
            this.group2.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.box4.SuspendLayout();
            this.box5.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.box7.SuspendLayout();
            this.box8.SuspendLayout();
            this.SuspendLayout();
            // 
            // mag
            // 
            this.mag.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.mag.Groups.Add(this.group1);
            this.mag.Groups.Add(this.group2);
            this.mag.Groups.Add(this.group3);
            this.mag.Groups.Add(this.group4);
            this.mag.Label = "MAG.bitrix24";
            this.mag.Name = "mag";
            this.mag.Visible = false;
            // 
            // group1
            // 
            this.group1.Items.Add(this.box1);
            this.group1.Items.Add(this.label1);
            this.group1.Items.Add(this.box6);
            this.group1.Name = "group1";
            // 
            // box1
            // 
            this.box1.Items.Add(this.label2);
            this.box1.Items.Add(this.label3);
            this.box1.Items.Add(this.label4);
            this.box1.Items.Add(this.label5);
            this.box1.Items.Add(this.enterID);
            this.box1.Items.Add(this.findByIdBtn);
            this.box1.Name = "box1";
            // 
            // label2
            // 
            this.label2.Label = " ";
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.Label = " ";
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.Label = " ";
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.Label = " ";
            this.label5.Name = "label5";
            // 
            // enterID
            // 
            this.enterID.Label = "Поиск по ID";
            this.enterID.MaxLength = 4;
            this.enterID.Name = "enterID";
            this.enterID.ScreenTip = "Поиск компании по ID";
            this.enterID.Text = null;
            // 
            // label1
            // 
            this.label1.Label = " ";
            this.label1.Name = "label1";
            // 
            // box6
            // 
            this.box6.Items.Add(this.findByEmail);
            this.box6.Items.Add(this.findByEmailBtn);
            this.box6.Name = "box6";
            // 
            // findByEmail
            // 
            this.findByEmail.Label = "Поиск по почте ";
            this.findByEmail.Name = "findByEmail";
            this.findByEmail.Text = null;
            // 
            // group2
            // 
            this.group2.Items.Add(this.box2);
            this.group2.Items.Add(this.box3);
            this.group2.Items.Add(this.director);
            this.group2.Items.Add(this.separator1);
            this.group2.Items.Add(this.box4);
            this.group2.Items.Add(this.box5);
            this.group2.Items.Add(this.phone);
            this.group2.Items.Add(this.manger);
            this.group2.Label = "Учетные данные ТА";
            this.group2.Name = "group2";
            // 
            // box2
            // 
            this.box2.Items.Add(this.login);
            this.box2.Items.Add(this.btnLogin);
            this.box2.Name = "box2";
            // 
            // login
            // 
            this.login.Label = "Логин: ";
            this.login.Name = "login";
            // 
            // box3
            // 
            this.box3.Items.Add(this.password);
            this.box3.Items.Add(this.btnPass);
            this.box3.Name = "box3";
            // 
            // password
            // 
            this.password.Label = "Пароль: ";
            this.password.Name = "password";
            // 
            // director
            // 
            this.director.Label = "                                                 ";
            this.director.Name = "director";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // box4
            // 
            this.box4.Items.Add(this.shadowlogin);
            this.box4.Items.Add(this.btnShLogin);
            this.box4.Name = "box4";
            // 
            // shadowlogin
            // 
            this.shadowlogin.Label = "Скрытый логин: ";
            this.shadowlogin.Name = "shadowlogin";
            // 
            // box5
            // 
            this.box5.Items.Add(this.shadowpass);
            this.box5.Items.Add(this.btnShPass);
            this.box5.Name = "box5";
            // 
            // shadowpass
            // 
            this.shadowpass.Label = "Скрытый пароль: ";
            this.shadowpass.Name = "shadowpass";
            // 
            // phone
            // 
            this.phone.Label = "                                                 ";
            this.phone.Name = "phone";
            // 
            // manger
            // 
            this.manger.Label = "Куратор:";
            this.manger.Name = "manger";
            // 
            // group3
            // 
            this.group3.Items.Add(this.sendMail);
            this.group3.Items.Add(this.sendLogPass);
            this.group3.Name = "group3";
            // 
            // group4
            // 
            this.group4.Items.Add(this.box7);
            this.group4.Items.Add(this.box8);
            this.group4.Items.Add(this.date);
            this.group4.Label = "Отправленные письма куратора";
            this.group4.Name = "group4";
            // 
            // label6
            // 
            this.label6.Label = "Отправлено писем";
            this.label6.Name = "label6";
            // 
            // label7
            // 
            this.label7.Label = "Последнее на";
            this.label7.Name = "label7";
            // 
            // box7
            // 
            this.box7.Items.Add(this.label6);
            this.box7.Items.Add(this.mailCount);
            this.box7.Name = "box7";
            // 
            // mailCount
            // 
            this.mailCount.Label = "0";
            this.mailCount.Name = "mailCount";
            // 
            // box8
            // 
            this.box8.Items.Add(this.label7);
            this.box8.Items.Add(this.lastMail);
            this.box8.Name = "box8";
            // 
            // lastMail
            // 
            this.lastMail.Label = " ";
            this.lastMail.Name = "lastMail";
            // 
            // bitrixAuth
            // 
            this.bitrixAuth.Label = "Bitrix.MAG";
            this.bitrixAuth.Name = "bitrixAuth";
            this.bitrixAuth.ShowImage = true;
            this.bitrixAuth.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BitrixAuth_Click);
            // 
            // findByIdBtn
            // 
            this.findByIdBtn.Label = "Найти";
            this.findByIdBtn.Name = "findByIdBtn";
            this.findByIdBtn.ScreenTip = "Найти компанию по ее ID";
            this.findByIdBtn.ShowImage = true;
            this.findByIdBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FindByIdBtn_Click);
            // 
            // findByEmailBtn
            // 
            this.findByEmailBtn.Label = "Найти";
            this.findByEmailBtn.Name = "findByEmailBtn";
            this.findByEmailBtn.ShowImage = true;
            this.findByEmailBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FindByEmailBtn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Label = " ";
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnLogin_Click);
            // 
            // btnPass
            // 
            this.btnPass.Enabled = false;
            this.btnPass.Label = " ";
            this.btnPass.Name = "btnPass";
            this.btnPass.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnLogin_Click);
            // 
            // btnShLogin
            // 
            this.btnShLogin.Enabled = false;
            this.btnShLogin.Label = " ";
            this.btnShLogin.Name = "btnShLogin";
            this.btnShLogin.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnLogin_Click);
            // 
            // btnShPass
            // 
            this.btnShPass.Enabled = false;
            this.btnShPass.Label = " ";
            this.btnShPass.Name = "btnShPass";
            this.btnShPass.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnLogin_Click);
            // 
            // sendMail
            // 
            this.sendMail.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sendMail.Enabled = false;
            this.sendMail.Label = "Отправить письмо куратора";
            this.sendMail.Name = "sendMail";
            this.sendMail.ScreenTip = "Отправить шаблон письма курратора";
            this.sendMail.ShowImage = true;
            this.sendMail.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SendMail_Click);
            // 
            // sendLogPass
            // 
            this.sendLogPass.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sendLogPass.Enabled = false;
            this.sendLogPass.Label = "Отправить данные регистрации";
            this.sendLogPass.Name = "sendLogPass";
            this.sendLogPass.ScreenTip = "Отправить шаблон письма с регистрационными данными из Битрикс";
            this.sendLogPass.ShowImage = true;
            this.sendLogPass.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SendLogPass_Click);
            // 
            // date
            // 
            this.date.Label = "в";
            this.date.Name = "date";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            // 
            // Ribbon1.OfficeMenu
            // 
            this.OfficeMenu.Items.Add(this.bitrixAuth);
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.mag);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.mag.ResumeLayout(false);
            this.mag.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box6.ResumeLayout(false);
            this.box6.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.box7.ResumeLayout(false);
            this.box7.PerformLayout();
            this.box8.ResumeLayout(false);
            this.box8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab mag;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox enterID;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton findByIdBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel director;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel login;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel password;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel shadowlogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel shadowpass;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel phone;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sendMail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sendLogPass;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPass;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShLogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShPass;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bitrixAuth;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box6;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox findByEmail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton findByEmailBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label3;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label4;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label5;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel manger;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box7;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label6;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box8;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label7;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel date;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel mailCount;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lastMail;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
