namespace client
{
    partial class ShopForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BookView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookViewContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.BookViewContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProfileButton);
            this.groupBox1.Controls.Add(this.cartButton);
            this.groupBox1.Controls.Add(this.regButton);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.UserBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(474, 11);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(75, 52);
            this.ProfileButton.TabIndex = 5;
            this.ProfileButton.Text = "Профиль";
            this.ProfileButton.UseVisualStyleBackColor = false;
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartButton.Location = new System.Drawing.Point(555, 11);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 52);
            this.cartButton.TabIndex = 4;
            this.cartButton.Text = "Корзина";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(633, 40);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(137, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(633, 11);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(137, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserBox
            // 
            this.UserBox.AutoSize = true;
            this.UserBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserBox.Location = new System.Drawing.Point(55, 25);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(48, 20);
            this.UserBox.TabIndex = 1;
            this.UserBox.Text = "user0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BookView);
            this.groupBox2.Location = new System.Drawing.Point(18, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BookView
            // 
            this.BookView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BookView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.BookView.ContextMenuStrip = this.BookViewContext;
            this.BookView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookView.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookView.HideSelection = false;
            this.BookView.LargeImageList = this.BookImageList;
            this.BookView.Location = new System.Drawing.Point(3, 16);
            this.BookView.Name = "BookView";
            this.BookView.Size = new System.Drawing.Size(764, 342);
            this.BookView.SmallImageList = this.BookImageList;
            this.BookView.TabIndex = 0;
            this.BookView.UseCompatibleStateImageBehavior = false;
            this.BookView.DoubleClick += new System.EventHandler(this.SelectedItem_DoubleClick);
            // 
            // BookViewContext
            // 
            this.BookViewContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyMenuItem,
            this.getInfoMenuItem});
            this.BookViewContext.Name = "BookViewContext";
            this.BookViewContext.Size = new System.Drawing.Size(195, 70);
            // 
            // buyMenuItem
            // 
            this.buyMenuItem.Name = "buyMenuItem";
            this.buyMenuItem.Size = new System.Drawing.Size(194, 22);
            this.buyMenuItem.Text = "Заказать";
            this.buyMenuItem.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // getInfoMenuItem
            // 
            this.getInfoMenuItem.Name = "getInfoMenuItem";
            this.getInfoMenuItem.Size = new System.Drawing.Size(194, 22);
            this.getInfoMenuItem.Text = "Посмотреть сведения";
            this.getInfoMenuItem.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // BookImageList
            // 
            this.BookImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.BookImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.BookImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopForm_FormClosing);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.BookViewContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView BookView;
        private System.Windows.Forms.ImageList BookImageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.ContextMenuStrip BookViewContext;
        private System.Windows.Forms.ToolStripMenuItem buyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInfoMenuItem;
    }
}