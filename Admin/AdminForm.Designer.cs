namespace client
{
    partial class AdminForm
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
            this.TableView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TablesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DestroyAllGuestsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ForceExitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.DelUserConfigOption = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupUserConfigOption = new System.Windows.Forms.ToolStripMenuItem();
            this.GetHelpOption = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BrowseIconButton = new System.Windows.Forms.Button();
            this.AcceptBookButton = new System.Windows.Forms.Button();
            this.BookDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookCost = new System.Windows.Forms.TextBox();
            this.BookCategory = new System.Windows.Forms.ComboBox();
            this.BookPublisher = new System.Windows.Forms.TextBox();
            this.BookYear = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DelBookButton = new System.Windows.Forms.Button();
            this.AvaliableBooks = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BrowseUserIconButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.BirthDateBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AcceptUserButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.MaskedTextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.SNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DelUserButton = new System.Windows.Forms.Button();
            this.AvaliableAccounts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(13, 319);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(666, 287);
            this.TableView.TabIndex = 0;
            this.TableView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RewriteTableOption_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TablesMenuItem,
            this.OperationsMenuItem,
            this.SystemMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TablesMenuItem
            // 
            this.TablesMenuItem.Name = "TablesMenuItem";
            this.TablesMenuItem.Size = new System.Drawing.Size(68, 20);
            this.TablesMenuItem.Text = "Таблицы";
            // 
            // OperationsMenuItem
            // 
            this.OperationsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem,
            this.DestroyAllGuestsOption});
            this.OperationsMenuItem.Name = "OperationsMenuItem";
            this.OperationsMenuItem.Size = new System.Drawing.Size(75, 20);
            this.OperationsMenuItem.Text = "Операции";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            // 
            // DestroyAllGuestsOption
            // 
            this.DestroyAllGuestsOption.Name = "DestroyAllGuestsOption";
            this.DestroyAllGuestsOption.Size = new System.Drawing.Size(215, 22);
            this.DestroyAllGuestsOption.Text = "Удалить Гостевые сеансы";
            this.DestroyAllGuestsOption.Click += new System.EventHandler(this.DestroyAllGuestsOption_Click);
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitOption,
            this.ForceExitOption,
            this.DelUserConfigOption,
            this.SetupUserConfigOption,
            this.GetHelpOption});
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Size = new System.Drawing.Size(66, 20);
            this.SystemMenuItem.Text = "Система";
            // 
            // ExitOption
            // 
            this.ExitOption.Name = "ExitOption";
            this.ExitOption.Size = new System.Drawing.Size(195, 22);
            this.ExitOption.Text = "Выйти";
            this.ExitOption.Click += new System.EventHandler(this.ExitOption_Click);
            // 
            // ForceExitOption
            // 
            this.ForceExitOption.Name = "ForceExitOption";
            this.ForceExitOption.Size = new System.Drawing.Size(195, 22);
            this.ForceExitOption.Text = "Срочно выйти";
            this.ForceExitOption.Click += new System.EventHandler(this.ForceExitOption_Click);
            // 
            // DelUserConfigOption
            // 
            this.DelUserConfigOption.Name = "DelUserConfigOption";
            this.DelUserConfigOption.Size = new System.Drawing.Size(195, 22);
            this.DelUserConfigOption.Text = "Стереть userconfig";
            this.DelUserConfigOption.Click += new System.EventHandler(this.DelUserConfigOption_Click);
            // 
            // SetupUserConfigOption
            // 
            this.SetupUserConfigOption.Name = "SetupUserConfigOption";
            this.SetupUserConfigOption.Size = new System.Drawing.Size(195, 22);
            this.SetupUserConfigOption.Text = "Установить userconfig";
            this.SetupUserConfigOption.Click += new System.EventHandler(this.SetupUserConfigOption_Click);
            // 
            // GetHelpOption
            // 
            this.GetHelpOption.Name = "GetHelpOption";
            this.GetHelpOption.Size = new System.Drawing.Size(195, 22);
            this.GetHelpOption.Text = "Справка";
            this.GetHelpOption.Click += new System.EventHandler(this.GetHelpOption_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BookAuthor);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.BrowseIconButton);
            this.groupBox1.Controls.Add(this.AcceptBookButton);
            this.groupBox1.Controls.Add(this.BookDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BookCost);
            this.groupBox1.Controls.Add(this.BookCategory);
            this.groupBox1.Controls.Add(this.BookPublisher);
            this.groupBox1.Controls.Add(this.BookYear);
            this.groupBox1.Controls.Add(this.BookName);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить книгу";
            // 
            // BookAuthor
            // 
            this.BookAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookAuthor.Location = new System.Drawing.Point(106, 53);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(125, 23);
            this.BookAuthor.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "Автор";
            // 
            // BrowseIconButton
            // 
            this.BrowseIconButton.BackColor = System.Drawing.Color.White;
            this.BrowseIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseIconButton.Location = new System.Drawing.Point(298, 58);
            this.BrowseIconButton.Name = "BrowseIconButton";
            this.BrowseIconButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseIconButton.TabIndex = 18;
            this.BrowseIconButton.Text = "...";
            this.BrowseIconButton.UseVisualStyleBackColor = false;
            this.BrowseIconButton.Click += new System.EventHandler(this.BrowseIconButton_Click);
            // 
            // AcceptBookButton
            // 
            this.AcceptBookButton.Enabled = false;
            this.AcceptBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBookButton.Location = new System.Drawing.Point(240, 171);
            this.AcceptBookButton.Name = "AcceptBookButton";
            this.AcceptBookButton.Size = new System.Drawing.Size(134, 23);
            this.AcceptBookButton.TabIndex = 17;
            this.AcceptBookButton.Text = "OK";
            this.AcceptBookButton.UseVisualStyleBackColor = true;
            this.AcceptBookButton.Click += new System.EventHandler(this.AcceptBookButton_Click);
            // 
            // BookDescription
            // 
            this.BookDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookDescription.Location = new System.Drawing.Point(240, 111);
            this.BookDescription.Multiline = true;
            this.BookDescription.Name = "BookDescription";
            this.BookDescription.Size = new System.Drawing.Size(134, 53);
            this.BookDescription.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Описание книги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Обложка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Издатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата (Y4-M2-D2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название";
            // 
            // BookCost
            // 
            this.BookCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookCost.Location = new System.Drawing.Point(106, 171);
            this.BookCost.Name = "BookCost";
            this.BookCost.Size = new System.Drawing.Size(125, 23);
            this.BookCost.TabIndex = 8;
            // 
            // BookCategory
            // 
            this.BookCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookCategory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookCategory.FormattingEnabled = true;
            this.BookCategory.Location = new System.Drawing.Point(106, 141);
            this.BookCategory.Name = "BookCategory";
            this.BookCategory.Size = new System.Drawing.Size(125, 23);
            this.BookCategory.TabIndex = 7;
            // 
            // BookPublisher
            // 
            this.BookPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookPublisher.Location = new System.Drawing.Point(106, 111);
            this.BookPublisher.Name = "BookPublisher";
            this.BookPublisher.Size = new System.Drawing.Size(125, 23);
            this.BookPublisher.TabIndex = 6;
            // 
            // BookYear
            // 
            this.BookYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookYear.Location = new System.Drawing.Point(106, 82);
            this.BookYear.Name = "BookYear";
            this.BookYear.Size = new System.Drawing.Size(125, 23);
            this.BookYear.TabIndex = 1;
            // 
            // BookName
            // 
            this.BookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookName.Location = new System.Drawing.Point(106, 22);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(125, 23);
            this.BookName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelBookButton);
            this.groupBox2.Controls.Add(this.AvaliableBooks);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удалить книгу";
            // 
            // DelBookButton
            // 
            this.DelBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBookButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelBookButton.Location = new System.Drawing.Point(6, 48);
            this.DelBookButton.Name = "DelBookButton";
            this.DelBookButton.Size = new System.Drawing.Size(95, 23);
            this.DelBookButton.TabIndex = 1;
            this.DelBookButton.Text = "ОК";
            this.DelBookButton.UseVisualStyleBackColor = true;
            this.DelBookButton.Click += new System.EventHandler(this.DelBookButton_Click);
            // 
            // AvaliableBooks
            // 
            this.AvaliableBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.AvaliableBooks.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvaliableBooks.FormattingEnabled = true;
            this.AvaliableBooks.Location = new System.Drawing.Point(6, 19);
            this.AvaliableBooks.Name = "AvaliableBooks";
            this.AvaliableBooks.Size = new System.Drawing.Size(249, 23);
            this.AvaliableBooks.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BrowseUserIconButton);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.BirthDateBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.AcceptUserButton);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.PasswordBox);
            this.groupBox3.Controls.Add(this.TypeBox);
            this.groupBox3.Controls.Add(this.FNameBox);
            this.groupBox3.Controls.Add(this.SNameBox);
            this.groupBox3.Controls.Add(this.NameBox);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(398, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 201);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить пользователя";
            // 
            // BrowseUserIconButton
            // 
            this.BrowseUserIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseUserIconButton.Location = new System.Drawing.Point(238, 21);
            this.BrowseUserIconButton.Name = "BrowseUserIconButton";
            this.BrowseUserIconButton.Size = new System.Drawing.Size(36, 23);
            this.BrowseUserIconButton.TabIndex = 14;
            this.BrowseUserIconButton.Text = "...";
            this.BrowseUserIconButton.UseVisualStyleBackColor = true;
            this.BrowseUserIconButton.Click += new System.EventHandler(this.BrowseUserIconButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Обложка";
            // 
            // BirthDateBox
            // 
            this.BirthDateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BirthDateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthDateBox.Location = new System.Drawing.Point(125, 168);
            this.BirthDateBox.Name = "BirthDateBox";
            this.BirthDateBox.Size = new System.Drawing.Size(149, 23);
            this.BirthDateBox.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Д.Р.  (YYYY-MM-DD)";
            // 
            // AcceptUserButton
            // 
            this.AcceptUserButton.Enabled = false;
            this.AcceptUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptUserButton.Location = new System.Drawing.Point(179, 139);
            this.AcceptUserButton.Name = "AcceptUserButton";
            this.AcceptUserButton.Size = new System.Drawing.Size(95, 23);
            this.AcceptUserButton.TabIndex = 10;
            this.AcceptUserButton.Text = "OK";
            this.AcceptUserButton.UseVisualStyleBackColor = true;
            this.AcceptUserButton.Click += new System.EventHandler(this.AcceptUserButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Уровень";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Пароль";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Имя, О.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ключ";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Location = new System.Drawing.Point(73, 109);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordBox.TabIndex = 4;
            // 
            // TypeBox
            // 
            this.TypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(73, 139);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 23);
            this.TypeBox.TabIndex = 3;
            // 
            // FNameBox
            // 
            this.FNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.FNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameBox.Location = new System.Drawing.Point(73, 79);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(100, 23);
            this.FNameBox.TabIndex = 2;
            // 
            // SNameBox
            // 
            this.SNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.SNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SNameBox.Location = new System.Drawing.Point(73, 50);
            this.SNameBox.Name = "SNameBox";
            this.SNameBox.Size = new System.Drawing.Size(100, 23);
            this.SNameBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(73, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DelUserButton);
            this.groupBox4.Controls.Add(this.AvaliableAccounts);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(398, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 78);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удалить пользователя";
            // 
            // DelUserButton
            // 
            this.DelUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelUserButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelUserButton.Location = new System.Drawing.Point(6, 48);
            this.DelUserButton.Name = "DelUserButton";
            this.DelUserButton.Size = new System.Drawing.Size(89, 23);
            this.DelUserButton.TabIndex = 1;
            this.DelUserButton.Text = "ОК";
            this.DelUserButton.UseVisualStyleBackColor = true;
            this.DelUserButton.Click += new System.EventHandler(this.DelUserButton_Click);
            // 
            // AvaliableAccounts
            // 
            this.AvaliableAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.AvaliableAccounts.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvaliableAccounts.FormattingEnabled = true;
            this.AvaliableAccounts.Location = new System.Drawing.Point(6, 19);
            this.AvaliableAccounts.Name = "AvaliableAccounts";
            this.AvaliableAccounts.Size = new System.Drawing.Size(268, 23);
            this.AvaliableAccounts.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 618);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(706, 623);
            this.Name = "AdminForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TablesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitOption;
        private System.Windows.Forms.ToolStripMenuItem ForceExitOption;
        private System.Windows.Forms.ToolStripMenuItem DelUserConfigOption;
        private System.Windows.Forms.ToolStripMenuItem SetupUserConfigOption;
        private System.Windows.Forms.ToolStripMenuItem GetHelpOption;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DelBookButton;
        private System.Windows.Forms.ComboBox AvaliableBooks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button DelUserButton;
        private System.Windows.Forms.ComboBox AvaliableAccounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookCost;
        private System.Windows.Forms.ComboBox BookCategory;
        private System.Windows.Forms.TextBox BookPublisher;
        private System.Windows.Forms.TextBox BookYear;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Button BrowseIconButton;
        private System.Windows.Forms.Button AcceptBookButton;
        private System.Windows.Forms.TextBox BookDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox SNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox PasswordBox;
        private System.Windows.Forms.Button AcceptUserButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem DestroyAllGuestsOption;
        private System.Windows.Forms.TextBox BirthDateBox;
        private System.Windows.Forms.Button BrowseUserIconButton;
        private System.Windows.Forms.Label label15;
    }
}