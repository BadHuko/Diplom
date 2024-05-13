namespace Simen1
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btSaveSettings = new Button();
            laLocate = new Label();
            laPsswd = new Label();
            tbLocateDB = new TextBox();
            tbPassword = new TextBox();
            laPort = new Label();
            tbPort = new TextBox();
            laDataBase = new Label();
            tbDataBase = new TextBox();
            SuspendLayout();
            // 
            // btSaveSettings
            // 
            btSaveSettings.BackColor = Color.FromArgb(255, 231, 76);
            btSaveSettings.ForeColor = Color.FromArgb(54, 97, 140);
            btSaveSettings.Location = new Point(151, 184);
            btSaveSettings.Name = "btSaveSettings";
            btSaveSettings.Size = new Size(75, 23);
            btSaveSettings.TabIndex = 0;
            btSaveSettings.Text = "Сохранить";
            btSaveSettings.UseVisualStyleBackColor = false;
            btSaveSettings.Click += btSaveSettings_Click;
            // 
            // laLocate
            // 
            laLocate.AutoSize = true;
            laLocate.ForeColor = Color.FromArgb(54, 97, 140);
            laLocate.Location = new Point(12, 22);
            laLocate.Name = "laLocate";
            laLocate.Size = new Size(113, 15);
            laLocate.TabIndex = 2;
            laLocate.Text = "Путь к базе данных";
            // 
            // laPsswd
            // 
            laPsswd.AutoSize = true;
            laPsswd.ForeColor = Color.FromArgb(54, 97, 140);
            laPsswd.Location = new Point(12, 88);
            laPsswd.Name = "laPsswd";
            laPsswd.Size = new Size(49, 15);
            laPsswd.TabIndex = 3;
            laPsswd.Text = "Пароль";
            // 
            // tbLocateDB
            // 
            tbLocateDB.BackColor = Color.White;
            tbLocateDB.ForeColor = Color.FromArgb(54, 97, 140);
            tbLocateDB.Location = new Point(12, 40);
            tbLocateDB.Multiline = true;
            tbLocateDB.Name = "tbLocateDB";
            tbLocateDB.Size = new Size(113, 23);
            tbLocateDB.TabIndex = 4;
            tbLocateDB.Text = "127.0.0.1";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.ForeColor = Color.FromArgb(54, 97, 140);
            tbPassword.Location = new Point(12, 106);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(113, 23);
            tbPassword.TabIndex = 5;
            tbPassword.Text = "MyPaasword";
            // 
            // laPort
            // 
            laPort.AutoSize = true;
            laPort.ForeColor = Color.FromArgb(54, 97, 140);
            laPort.Location = new Point(151, 22);
            laPort.Name = "laPort";
            laPort.Size = new Size(35, 15);
            laPort.TabIndex = 6;
            laPort.Text = "Порт";
            // 
            // tbPort
            // 
            tbPort.BackColor = Color.White;
            tbPort.ForeColor = Color.FromArgb(54, 97, 140);
            tbPort.Location = new Point(151, 40);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(75, 23);
            tbPort.TabIndex = 7;
            tbPort.Text = "3306";
            // 
            // laDataBase
            // 
            laDataBase.AutoSize = true;
            laDataBase.ForeColor = Color.FromArgb(54, 97, 140);
            laDataBase.Location = new Point(151, 88);
            laDataBase.Name = "laDataBase";
            laDataBase.Size = new Size(75, 15);
            laDataBase.TabIndex = 8;
            laDataBase.Text = "База данных";
            // 
            // tbDataBase
            // 
            tbDataBase.BackColor = Color.White;
            tbDataBase.ForeColor = Color.FromArgb(54, 97, 140);
            tbDataBase.Location = new Point(151, 106);
            tbDataBase.Name = "tbDataBase";
            tbDataBase.Size = new Size(75, 23);
            tbDataBase.TabIndex = 9;
            tbDataBase.Text = "MyDataBase";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(237, 233);
            Controls.Add(tbDataBase);
            Controls.Add(laDataBase);
            Controls.Add(tbPort);
            Controls.Add(laPort);
            Controls.Add(tbPassword);
            Controls.Add(tbLocateDB);
            Controls.Add(laPsswd);
            Controls.Add(laLocate);
            Controls.Add(btSaveSettings);
            ForeColor = Color.FromArgb(54, 97, 140);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Settings";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSaveSettings;
        private Label laLocate;
        private Label laPsswd;
        private TextBox tbLocateDB;
        private TextBox tbPassword;
        private Label laPort;
        private TextBox tbPort;
        private Label laDataBase;
        private TextBox tbDataBase;
    }
}