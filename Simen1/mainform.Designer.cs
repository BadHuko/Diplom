namespace Simen1
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Refresh = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button7 = new Button();
            button5 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            button8 = new Button();
            button6 = new Button();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            button10 = new Button();
            button9 = new Button();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            button11 = new Button();
            checkBox1 = new CheckBox();
            textBox5 = new TextBox();
            lbPassword = new Label();
            textBox4 = new TextBox();
            lbName = new Label();
            tbDataBase = new TextBox();
            laDataBase = new Label();
            tbPort = new TextBox();
            laPort = new Label();
            tbPassword = new TextBox();
            tbLocateDB = new TextBox();
            laPsswd = new Label();
            laLocate = new Label();
            btSaveSettings = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(702, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(Refresh);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(694, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Воздуховод";
            // 
            // Refresh
            // 
            Refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Refresh.BackColor = Color.White;
            Refresh.BackgroundImage = Properties.Resources.refresh_icon;
            Refresh.BackgroundImageLayout = ImageLayout.Zoom;
            Refresh.FlatAppearance.BorderSize = 2;
            Refresh.Location = new Point(511, 6);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(22, 22);
            Refresh.TabIndex = 4;
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.FromArgb(54, 97, 140);
            textBox1.Location = new Point(520, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 22);
            textBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(255, 231, 76);
            button4.ForeColor = Color.FromArgb(54, 97, 140);
            button4.Location = new Point(603, 350);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Выбрать";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 231, 76);
            button1.ForeColor = Color.FromArgb(54, 97, 140);
            button1.Location = new Point(514, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CommonButtonClickHandler;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(56, 97, 140);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(505, 420);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(694, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отвод";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.White;
            button7.BackgroundImage = Properties.Resources.refresh_icon;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 2;
            button7.Location = new Point(511, 6);
            button7.Name = "button7";
            button7.Size = new Size(22, 22);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(255, 231, 76);
            button5.ForeColor = Color.FromArgb(54, 97, 140);
            button5.Location = new Point(603, 350);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Выбрать";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 231, 76);
            button2.ForeColor = Color.FromArgb(54, 97, 140);
            button2.Location = new Point(514, 350);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CommonButtonClickHandler;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(505, 420);
            dataGridView2.TabIndex = 1;
            dataGridView2.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(694, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Тройник";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.BackColor = Color.White;
            button8.BackgroundImage = Properties.Resources.refresh_icon;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatAppearance.BorderSize = 2;
            button8.Location = new Point(511, 6);
            button8.Name = "button8";
            button8.Size = new Size(22, 22);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(255, 231, 76);
            button6.ForeColor = Color.FromArgb(54, 97, 140);
            button6.Location = new Point(603, 350);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = "Выбрать";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 231, 76);
            button3.ForeColor = Color.FromArgb(54, 97, 140);
            button3.Location = new Point(514, 350);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += CommonButtonClickHandler;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView3.GridColor = Color.FromArgb(56, 97, 140);
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(505, 420);
            dataGridView3.TabIndex = 2;
            dataGridView3.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.BorderStyle = BorderStyle.FixedSingle;
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(694, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Выбранные данные";
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(255, 231, 76);
            button10.ForeColor = Color.FromArgb(54, 97, 140);
            button10.Location = new Point(512, 348);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 4;
            button10.Text = "Удалить";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(255, 231, 76);
            button9.ForeColor = Color.FromArgb(54, 97, 140);
            button9.Location = new Point(601, 348);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 3;
            button9.Text = "Экспорт";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.BackgroundColor = SystemColors.Window;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView4.GridColor = Color.FromArgb(56, 97, 140);
            dataGridView4.Location = new Point(3, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(56, 97, 140);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView4.Size = new Size(503, 418);
            dataGridView4.TabIndex = 1;
            dataGridView4.TabStop = false;
            dataGridView4.CellValueChanged += dataGridView4_CellValueChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button11);
            tabPage5.Controls.Add(checkBox1);
            tabPage5.Controls.Add(textBox5);
            tabPage5.Controls.Add(lbPassword);
            tabPage5.Controls.Add(textBox4);
            tabPage5.Controls.Add(lbName);
            tabPage5.Controls.Add(tbDataBase);
            tabPage5.Controls.Add(laDataBase);
            tabPage5.Controls.Add(tbPort);
            tabPage5.Controls.Add(laPort);
            tabPage5.Controls.Add(tbPassword);
            tabPage5.Controls.Add(tbLocateDB);
            tabPage5.Controls.Add(laPsswd);
            tabPage5.Controls.Add(laLocate);
            tabPage5.Controls.Add(btSaveSettings);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(694, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Настройки администратора";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 231, 76);
            button11.ForeColor = Color.FromArgb(54, 97, 140);
            button11.Location = new Point(587, 177);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 25;
            button11.Text = "Создать";
            button11.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(453, 88);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Администратор";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.ForeColor = Color.FromArgb(54, 97, 140);
            textBox5.Location = new Point(563, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(99, 23);
            textBox5.TabIndex = 23;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = Color.FromArgb(54, 97, 140);
            lbPassword.Location = new Point(563, 23);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(49, 15);
            lbPassword.TabIndex = 22;
            lbPassword.Text = "Пароль";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.ForeColor = Color.FromArgb(54, 97, 140);
            textBox4.Location = new Point(453, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(88, 23);
            textBox4.TabIndex = 21;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.FromArgb(54, 97, 140);
            lbName.Location = new Point(453, 23);
            lbName.Name = "lbName";
            lbName.Size = new Size(41, 15);
            lbName.TabIndex = 20;
            lbName.Text = "Логин";
            // 
            // tbDataBase
            // 
            tbDataBase.BackColor = Color.White;
            tbDataBase.ForeColor = Color.FromArgb(54, 97, 140);
            tbDataBase.Location = new Point(148, 107);
            tbDataBase.Name = "tbDataBase";
            tbDataBase.Size = new Size(75, 23);
            tbDataBase.TabIndex = 19;
            tbDataBase.Text = "MyDataBase";
            // 
            // laDataBase
            // 
            laDataBase.AutoSize = true;
            laDataBase.ForeColor = Color.FromArgb(54, 97, 140);
            laDataBase.Location = new Point(148, 89);
            laDataBase.Name = "laDataBase";
            laDataBase.Size = new Size(75, 15);
            laDataBase.TabIndex = 18;
            laDataBase.Text = "База данных";
            // 
            // tbPort
            // 
            tbPort.BackColor = Color.White;
            tbPort.ForeColor = Color.FromArgb(54, 97, 140);
            tbPort.Location = new Point(148, 41);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(75, 23);
            tbPort.TabIndex = 17;
            tbPort.Text = "3306";
            // 
            // laPort
            // 
            laPort.AutoSize = true;
            laPort.ForeColor = Color.FromArgb(54, 97, 140);
            laPort.Location = new Point(148, 23);
            laPort.Name = "laPort";
            laPort.Size = new Size(35, 15);
            laPort.TabIndex = 16;
            laPort.Text = "Порт";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.ForeColor = Color.FromArgb(54, 97, 140);
            tbPassword.Location = new Point(9, 107);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(113, 23);
            tbPassword.TabIndex = 15;
            tbPassword.Text = "MyPaasword";
            // 
            // tbLocateDB
            // 
            tbLocateDB.BackColor = Color.White;
            tbLocateDB.ForeColor = Color.FromArgb(54, 97, 140);
            tbLocateDB.Location = new Point(9, 41);
            tbLocateDB.Multiline = true;
            tbLocateDB.Name = "tbLocateDB";
            tbLocateDB.Size = new Size(113, 23);
            tbLocateDB.TabIndex = 14;
            tbLocateDB.Text = "127.0.0.1";
            // 
            // laPsswd
            // 
            laPsswd.AutoSize = true;
            laPsswd.ForeColor = Color.FromArgb(54, 97, 140);
            laPsswd.Location = new Point(9, 89);
            laPsswd.Name = "laPsswd";
            laPsswd.Size = new Size(49, 15);
            laPsswd.TabIndex = 13;
            laPsswd.Text = "Пароль";
            // 
            // laLocate
            // 
            laLocate.AutoSize = true;
            laLocate.ForeColor = Color.FromArgb(54, 97, 140);
            laLocate.Location = new Point(9, 23);
            laLocate.Name = "laLocate";
            laLocate.Size = new Size(113, 15);
            laLocate.TabIndex = 12;
            laLocate.Text = "Путь к базе данных";
            // 
            // btSaveSettings
            // 
            btSaveSettings.BackColor = Color.FromArgb(255, 231, 76);
            btSaveSettings.ForeColor = Color.FromArgb(54, 97, 140);
            btSaveSettings.Location = new Point(148, 177);
            btSaveSettings.Name = "btSaveSettings";
            btSaveSettings.Size = new Size(75, 23);
            btSaveSettings.TabIndex = 10;
            btSaveSettings.Text = "Сохранить";
            btSaveSettings.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(tabControl1);
            ForeColor = Color.FromArgb(56, 97, 140);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Форма данных";
            Load += mainform_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn s;
        private DataGridViewTextBoxColumn D;
        private DataGridViewTextBoxColumn TWall;
        private DataGridViewTextBoxColumn TFlance;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Button Refresh;
        private Button button7;
        private Button button8;
        private TabPage tabPage4;
        private Button button9;
        private DataGridView dataGridView4;
        private Button button10;
        private TabPage tabPage5;
        private TextBox textBox5;
        private Label lbPassword;
        private TextBox textBox4;
        private Label lbName;
        private TextBox tbDataBase;
        private Label laDataBase;
        private TextBox tbPort;
        private Label laPort;
        private TextBox tbPassword;
        private TextBox tbLocateDB;
        private Label laPsswd;
        private Label laLocate;
        private Button btSaveSettings;
        private Button button11;
        private CheckBox checkBox1;
    }
}