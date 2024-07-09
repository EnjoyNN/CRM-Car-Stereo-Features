namespace WinFormsApp_FilterMySQL
{
    partial class FormMain
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
            this.maskedTextBox_Search = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_InsertName = new System.Windows.Forms.MaskedTextBox();
            this.label_PO = new System.Windows.Forms.Label();
            this.label_Param = new System.Windows.Forms.Label();
            this.label_Search = new System.Windows.Forms.Label();
            this.label_bluetooth = new System.Windows.Forms.Label();
            this.label_Vhod = new System.Windows.Forms.Label();
            this.label_Garant = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.maskedTextBox_InsertPrice = new System.Windows.Forms.MaskedTextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_bluetooth = new System.Windows.Forms.CheckBox();
            this.checkBox_Garant = new System.Windows.Forms.CheckBox();
            this.checkBox_Vhod = new System.Windows.Forms.CheckBox();
            this.DG_Table = new System.Windows.Forms.DataGridView();
            this.comboBox_PO = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_price = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Updateparam = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_Updatetext = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_IDUpdate = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Delete = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox_Insertmanufacturer = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_Insertformats = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_insertinput = new System.Windows.Forms.CheckBox();
            this.checkBox_insertguarantee = new System.Windows.Forms.CheckBox();
            this.checkBox_insertbluetooth = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bluetooth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IDUpdate)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox_Search
            // 
            this.maskedTextBox_Search.Location = new System.Drawing.Point(190, 87);
            this.maskedTextBox_Search.Name = "maskedTextBox_Search";
            this.maskedTextBox_Search.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox_Search.TabIndex = 1;
            // 
            // maskedTextBox_InsertName
            // 
            this.maskedTextBox_InsertName.Location = new System.Drawing.Point(190, 19);
            this.maskedTextBox_InsertName.Name = "maskedTextBox_InsertName";
            this.maskedTextBox_InsertName.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_InsertName.TabIndex = 2;
            // 
            // label_PO
            // 
            this.label_PO.AutoSize = true;
            this.label_PO.Location = new System.Drawing.Point(26, 48);
            this.label_PO.Name = "label_PO";
            this.label_PO.Size = new System.Drawing.Size(114, 13);
            this.label_PO.TabIndex = 3;
            this.label_PO.Text = "Выберите категорию";
            // 
            // label_Param
            // 
            this.label_Param.AutoSize = true;
            this.label_Param.Location = new System.Drawing.Point(26, 132);
            this.label_Param.Name = "label_Param";
            this.label_Param.Size = new System.Drawing.Size(120, 13);
            this.label_Param.TabIndex = 4;
            this.label_Param.Text = "Выберите параметры:";
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(26, 90);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(150, 13);
            this.label_Search.TabIndex = 5;
            this.label_Search.Text = "Введите данные для поиска";
            // 
            // label_bluetooth
            // 
            this.label_bluetooth.AutoSize = true;
            this.label_bluetooth.Location = new System.Drawing.Point(94, 180);
            this.label_bluetooth.Name = "label_bluetooth";
            this.label_bluetooth.Size = new System.Drawing.Size(52, 13);
            this.label_bluetooth.TabIndex = 6;
            this.label_bluetooth.Text = "Bluetooth";
            // 
            // label_Vhod
            // 
            this.label_Vhod.AutoSize = true;
            this.label_Vhod.Location = new System.Drawing.Point(94, 247);
            this.label_Vhod.Name = "label_Vhod";
            this.label_Vhod.Size = new System.Drawing.Size(168, 13);
            this.label_Vhod.TabIndex = 7;
            this.label_Vhod.Text = "Вход аудио на передней панели";
            // 
            // label_Garant
            // 
            this.label_Garant.AutoSize = true;
            this.label_Garant.Location = new System.Drawing.Point(94, 214);
            this.label_Garant.Name = "label_Garant";
            this.label_Garant.Size = new System.Drawing.Size(54, 13);
            this.label_Garant.TabIndex = 8;
            this.label_Garant.Text = "Гарантия";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 22);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(172, 13);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "Название модели автомагнитол";
            // 
            // maskedTextBox_InsertPrice
            // 
            this.maskedTextBox_InsertPrice.Location = new System.Drawing.Point(190, 56);
            this.maskedTextBox_InsertPrice.Name = "maskedTextBox_InsertPrice";
            this.maskedTextBox_InsertPrice.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_InsertPrice.TabIndex = 13;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(106, 288);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(162, 26);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Добавить автомагнитолу";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(668, 669);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(95, 26);
            this.button_Exit.TabIndex = 19;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // checkBox_bluetooth
            // 
            this.checkBox_bluetooth.AutoSize = true;
            this.checkBox_bluetooth.Location = new System.Drawing.Point(73, 179);
            this.checkBox_bluetooth.Name = "checkBox_bluetooth";
            this.checkBox_bluetooth.Size = new System.Drawing.Size(15, 14);
            this.checkBox_bluetooth.TabIndex = 21;
            this.checkBox_bluetooth.UseVisualStyleBackColor = true;
            // 
            // checkBox_Garant
            // 
            this.checkBox_Garant.AutoSize = true;
            this.checkBox_Garant.Location = new System.Drawing.Point(73, 213);
            this.checkBox_Garant.Name = "checkBox_Garant";
            this.checkBox_Garant.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Garant.TabIndex = 22;
            this.checkBox_Garant.UseVisualStyleBackColor = true;
            // 
            // checkBox_Vhod
            // 
            this.checkBox_Vhod.AutoSize = true;
            this.checkBox_Vhod.Location = new System.Drawing.Point(73, 247);
            this.checkBox_Vhod.Name = "checkBox_Vhod";
            this.checkBox_Vhod.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Vhod.TabIndex = 23;
            this.checkBox_Vhod.UseVisualStyleBackColor = true;
            // 
            // DG_Table
            // 
            this.DG_Table.AllowUserToAddRows = false;
            this.DG_Table.AllowUserToDeleteRows = false;
            this.DG_Table.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DG_Table.ColumnHeadersHeight = 35;
            this.DG_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name1,
            this.Price,
            this.Formats,
            this.Manufacturer,
            this.Bluetooth,
            this.Garant,
            this.Audio});
            this.DG_Table.Location = new System.Drawing.Point(440, 36);
            this.DG_Table.Name = "DG_Table";
            this.DG_Table.ReadOnly = true;
            this.DG_Table.RowHeadersWidth = 20;
            this.DG_Table.RowTemplate.Height = 20;
            this.DG_Table.Size = new System.Drawing.Size(538, 608);
            this.DG_Table.TabIndex = 24;
            // 
            // comboBox_PO
            // 
            this.comboBox_PO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PO.FormattingEnabled = true;
            this.comboBox_PO.Items.AddRange(new object[] {
            "Цена",
            "Название",
            "ID",
            "Поддерживаемые форматы",
            "Производитель"});
            this.comboBox_PO.Location = new System.Drawing.Point(190, 45);
            this.comboBox_PO.Name = "comboBox_PO";
            this.comboBox_PO.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PO.TabIndex = 25;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(175, 261);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(88, 26);
            this.button_Search.TabIndex = 26;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Location = new System.Drawing.Point(15, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 297);
            this.panel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 356);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 343);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 356);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.checkBox_insertinput);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkBox_insertguarantee);
            this.tabPage1.Controls.Add(this.maskedTextBox_Insertformats);
            this.tabPage1.Controls.Add(this.checkBox_insertbluetooth);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.maskedTextBox_Insertmanufacturer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.maskedTextBox_InsertName);
            this.tabPage1.Controls.Add(this.label_name);
            this.tabPage1.Controls.Add(this.maskedTextBox_InsertPrice);
            this.tabPage1.Controls.Add(this.label_price);
            this.tabPage1.Controls.Add(this.button_Add);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление автомагнитолы";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(14, 59);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(33, 13);
            this.label_price.TabIndex = 10;
            this.label_price.Text = "Цена";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.button_Update);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox_Updateparam);
            this.tabPage2.Controls.Add(this.maskedTextBox_Updatetext);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown_IDUpdate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение автомагнитолы";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(156, 287);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(78, 26);
            this.button_Update.TabIndex = 32;
            this.button_Update.Text = "Изменить";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Введите нужное значение";
            // 
            // comboBox_Updateparam
            // 
            this.comboBox_Updateparam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Updateparam.FormattingEnabled = true;
            this.comboBox_Updateparam.Items.AddRange(new object[] {
            "Цена",
            "Название",
            "Поддерживаемые форматы",
            "Производитель",
            "Поддержка Bluetooth",
            "Гарантия",
            "Вход аудио на передней панели"});
            this.comboBox_Updateparam.Location = new System.Drawing.Point(199, 77);
            this.comboBox_Updateparam.Name = "comboBox_Updateparam";
            this.comboBox_Updateparam.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Updateparam.TabIndex = 31;
            // 
            // maskedTextBox_Updatetext
            // 
            this.maskedTextBox_Updatetext.Location = new System.Drawing.Point(199, 126);
            this.maskedTextBox_Updatetext.Name = "maskedTextBox_Updatetext";
            this.maskedTextBox_Updatetext.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox_Updatetext.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Изменяемый параметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите ID магнитолы";
            // 
            // numericUpDown_IDUpdate
            // 
            this.numericUpDown_IDUpdate.Location = new System.Drawing.Point(199, 32);
            this.numericUpDown_IDUpdate.Name = "numericUpDown_IDUpdate";
            this.numericUpDown_IDUpdate.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_IDUpdate.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.button_delete);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.numericUpDown_Delete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(402, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удаление";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(156, 287);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(78, 26);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ID магнитолы";
            // 
            // numericUpDown_Delete
            // 
            this.numericUpDown_Delete.Location = new System.Drawing.Point(199, 32);
            this.numericUpDown_Delete.Name = "numericUpDown_Delete";
            this.numericUpDown_Delete.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_Delete.TabIndex = 0;
            // 
            // maskedTextBox_Insertmanufacturer
            // 
            this.maskedTextBox_Insertmanufacturer.Location = new System.Drawing.Point(190, 94);
            this.maskedTextBox_Insertmanufacturer.Name = "maskedTextBox_Insertmanufacturer";
            this.maskedTextBox_Insertmanufacturer.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Insertmanufacturer.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Производитель";
            // 
            // maskedTextBox_Insertformats
            // 
            this.maskedTextBox_Insertformats.Location = new System.Drawing.Point(190, 132);
            this.maskedTextBox_Insertformats.Name = "maskedTextBox_Insertformats";
            this.maskedTextBox_Insertformats.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Insertformats.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Поддерживаемые форматы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Гарантия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Вход аудио на передней панели";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bluetooth";
            // 
            // checkBox_insertinput
            // 
            this.checkBox_insertinput.AutoSize = true;
            this.checkBox_insertinput.Location = new System.Drawing.Point(195, 246);
            this.checkBox_insertinput.Name = "checkBox_insertinput";
            this.checkBox_insertinput.Size = new System.Drawing.Size(15, 14);
            this.checkBox_insertinput.TabIndex = 32;
            this.checkBox_insertinput.UseVisualStyleBackColor = true;
            // 
            // checkBox_insertguarantee
            // 
            this.checkBox_insertguarantee.AutoSize = true;
            this.checkBox_insertguarantee.Location = new System.Drawing.Point(195, 212);
            this.checkBox_insertguarantee.Name = "checkBox_insertguarantee";
            this.checkBox_insertguarantee.Size = new System.Drawing.Size(15, 14);
            this.checkBox_insertguarantee.TabIndex = 31;
            this.checkBox_insertguarantee.UseVisualStyleBackColor = true;
            // 
            // checkBox_insertbluetooth
            // 
            this.checkBox_insertbluetooth.AutoSize = true;
            this.checkBox_insertbluetooth.Location = new System.Drawing.Point(195, 178);
            this.checkBox_insertbluetooth.Name = "checkBox_insertbluetooth";
            this.checkBox_insertbluetooth.Size = new System.Drawing.Size(15, 14);
            this.checkBox_insertbluetooth.TabIndex = 30;
            this.checkBox_insertbluetooth.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Имя";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Formats
            // 
            this.Formats.HeaderText = "Форматы";
            this.Formats.Name = "Formats";
            this.Formats.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Производитель";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Bluetooth
            // 
            this.Bluetooth.HeaderText = "Bluetooth";
            this.Bluetooth.Name = "Bluetooth";
            this.Bluetooth.ReadOnly = true;
            this.Bluetooth.Width = 60;
            // 
            // Garant
            // 
            this.Garant.HeaderText = "Гарантия";
            this.Garant.Name = "Garant";
            this.Garant.ReadOnly = true;
            this.Garant.Width = 60;
            // 
            // Audio
            // 
            this.Audio.HeaderText = "Вход аудио спереди";
            this.Audio.Name = "Audio";
            this.Audio.ReadOnly = true;
            this.Audio.Width = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 712);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_PO);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.DG_Table);
            this.Controls.Add(this.checkBox_Vhod);
            this.Controls.Add(this.checkBox_Garant);
            this.Controls.Add(this.checkBox_bluetooth);
            this.Controls.Add(this.label_Garant);
            this.Controls.Add(this.label_Vhod);
            this.Controls.Add(this.label_bluetooth);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label_Param);
            this.Controls.Add(this.label_PO);
            this.Controls.Add(this.maskedTextBox_Search);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных автомагнитол";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IDUpdate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_Search;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_InsertName;
        private System.Windows.Forms.Label label_PO;
        private System.Windows.Forms.Label label_Param;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Label label_bluetooth;
        private System.Windows.Forms.Label label_Vhod;
        private System.Windows.Forms.Label label_Garant;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_InsertPrice;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_bluetooth;
        private System.Windows.Forms.CheckBox checkBox_Garant;
        private System.Windows.Forms.CheckBox checkBox_Vhod;
        private System.Windows.Forms.DataGridView DG_Table;
        private System.Windows.Forms.ComboBox comboBox_PO;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Updateparam;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Updatetext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_IDUpdate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Delete;
        private System.Windows.Forms.CheckBox checkBox_insertinput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_insertguarantee;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Insertformats;
        private System.Windows.Forms.CheckBox checkBox_insertbluetooth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Insertmanufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bluetooth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audio;
    }
}