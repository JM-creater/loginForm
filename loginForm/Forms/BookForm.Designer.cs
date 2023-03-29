namespace loginForm
{
    partial class BookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.btn_AddBook = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txt_BookTitle = new Guna.UI.WinForms.GunaTextBox();
            this.txt_BookAuthor = new Guna.UI.WinForms.GunaTextBox();
            this.numeric_BookQty = new Guna.UI.WinForms.GunaNumeric();
            this.txt_SearchBox = new Guna.UI.WinForms.GunaTextBox();
            this.btn_DeleteBook = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_EditBook = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.datagrid_Book = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Author:";
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(859, 246);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(125, 22);
            this.txt_BookID.TabIndex = 6;
            this.txt_BookID.Visible = false;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.AnimationHoverSpeed = 0.07F;
            this.btn_AddBook.AnimationSpeed = 0.03F;
            this.btn_AddBook.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddBook.BaseColor1 = System.Drawing.Color.LimeGreen;
            this.btn_AddBook.BaseColor2 = System.Drawing.Color.LimeGreen;
            this.btn_AddBook.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_AddBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddBook.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBook.ForeColor = System.Drawing.Color.White;
            this.btn_AddBook.Image = null;
            this.btn_AddBook.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddBook.Location = new System.Drawing.Point(18, 148);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.OnHoverBaseColor1 = System.Drawing.Color.Chartreuse;
            this.btn_AddBook.OnHoverBaseColor2 = System.Drawing.Color.Chartreuse;
            this.btn_AddBook.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_AddBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AddBook.OnHoverImage = null;
            this.btn_AddBook.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AddBook.Radius = 8;
            this.btn_AddBook.Size = new System.Drawing.Size(160, 42);
            this.btn_AddBook.TabIndex = 8;
            this.btn_AddBook.Text = "Add";
            this.btn_AddBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // txt_BookTitle
            // 
            this.txt_BookTitle.BackColor = System.Drawing.Color.Transparent;
            this.txt_BookTitle.BaseColor = System.Drawing.Color.White;
            this.txt_BookTitle.BorderColor = System.Drawing.Color.Silver;
            this.txt_BookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BookTitle.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_BookTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_BookTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_BookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_BookTitle.Location = new System.Drawing.Point(18, 38);
            this.txt_BookTitle.Name = "txt_BookTitle";
            this.txt_BookTitle.PasswordChar = '\0';
            this.txt_BookTitle.Radius = 8;
            this.txt_BookTitle.SelectedText = "";
            this.txt_BookTitle.Size = new System.Drawing.Size(248, 32);
            this.txt_BookTitle.TabIndex = 9;
            // 
            // txt_BookAuthor
            // 
            this.txt_BookAuthor.BackColor = System.Drawing.Color.Transparent;
            this.txt_BookAuthor.BaseColor = System.Drawing.Color.White;
            this.txt_BookAuthor.BorderColor = System.Drawing.Color.Silver;
            this.txt_BookAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BookAuthor.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_BookAuthor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_BookAuthor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_BookAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_BookAuthor.Location = new System.Drawing.Point(292, 38);
            this.txt_BookAuthor.Name = "txt_BookAuthor";
            this.txt_BookAuthor.PasswordChar = '\0';
            this.txt_BookAuthor.Radius = 8;
            this.txt_BookAuthor.SelectedText = "";
            this.txt_BookAuthor.Size = new System.Drawing.Size(248, 32);
            this.txt_BookAuthor.TabIndex = 9;
            // 
            // numeric_BookQty
            // 
            this.numeric_BookQty.BackColor = System.Drawing.Color.Transparent;
            this.numeric_BookQty.BaseColor = System.Drawing.Color.White;
            this.numeric_BookQty.BorderColor = System.Drawing.Color.Silver;
            this.numeric_BookQty.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numeric_BookQty.ButtonForeColor = System.Drawing.Color.White;
            this.numeric_BookQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeric_BookQty.ForeColor = System.Drawing.Color.Black;
            this.numeric_BookQty.Location = new System.Drawing.Point(156, 85);
            this.numeric_BookQty.Maximum = ((long)(9999999));
            this.numeric_BookQty.Minimum = ((long)(0));
            this.numeric_BookQty.Name = "numeric_BookQty";
            this.numeric_BookQty.Radius = 8;
            this.numeric_BookQty.Size = new System.Drawing.Size(248, 30);
            this.numeric_BookQty.TabIndex = 10;
            this.numeric_BookQty.Text = "gunaNumeric1";
            this.numeric_BookQty.Value = ((long)(0));
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.txt_SearchBox.BaseColor = System.Drawing.Color.White;
            this.txt_SearchBox.BorderColor = System.Drawing.Color.Silver;
            this.txt_SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchBox.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_SearchBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SearchBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchBox.Location = new System.Drawing.Point(8, 221);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.PasswordChar = '\0';
            this.txt_SearchBox.Radius = 8;
            this.txt_SearchBox.SelectedText = "";
            this.txt_SearchBox.Size = new System.Drawing.Size(290, 32);
            this.txt_SearchBox.TabIndex = 11;
            this.txt_SearchBox.TextChanged += new System.EventHandler(this.txt_SearchBox_TextChanged);
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.AnimationHoverSpeed = 0.07F;
            this.btn_DeleteBook.AnimationSpeed = 0.03F;
            this.btn_DeleteBook.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteBook.BaseColor1 = System.Drawing.Color.Red;
            this.btn_DeleteBook.BaseColor2 = System.Drawing.Color.Red;
            this.btn_DeleteBook.BorderColor = System.Drawing.Color.Red;
            this.btn_DeleteBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_DeleteBook.FocusedColor = System.Drawing.Color.Empty;
            this.btn_DeleteBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DeleteBook.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteBook.Image = null;
            this.btn_DeleteBook.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_DeleteBook.Location = new System.Drawing.Point(380, 148);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.OnHoverBaseColor1 = System.Drawing.Color.Salmon;
            this.btn_DeleteBook.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btn_DeleteBook.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_DeleteBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_DeleteBook.OnHoverImage = null;
            this.btn_DeleteBook.OnPressedColor = System.Drawing.Color.Black;
            this.btn_DeleteBook.Radius = 8;
            this.btn_DeleteBook.Size = new System.Drawing.Size(160, 42);
            this.btn_DeleteBook.TabIndex = 12;
            this.btn_DeleteBook.Text = "Delete";
            this.btn_DeleteBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // btn_EditBook
            // 
            this.btn_EditBook.AnimationHoverSpeed = 0.07F;
            this.btn_EditBook.AnimationSpeed = 0.03F;
            this.btn_EditBook.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditBook.BaseColor1 = System.Drawing.Color.RoyalBlue;
            this.btn_EditBook.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.btn_EditBook.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_EditBook.FocusedColor = System.Drawing.Color.Empty;
            this.btn_EditBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditBook.ForeColor = System.Drawing.Color.White;
            this.btn_EditBook.Image = null;
            this.btn_EditBook.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_EditBook.Location = new System.Drawing.Point(199, 148);
            this.btn_EditBook.Name = "btn_EditBook";
            this.btn_EditBook.OnHoverBaseColor1 = System.Drawing.Color.LightSkyBlue;
            this.btn_EditBook.OnHoverBaseColor2 = System.Drawing.Color.LightSkyBlue;
            this.btn_EditBook.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_EditBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_EditBook.OnHoverImage = null;
            this.btn_EditBook.OnPressedColor = System.Drawing.Color.Black;
            this.btn_EditBook.Radius = 8;
            this.btn_EditBook.Size = new System.Drawing.Size(160, 42);
            this.btn_EditBook.TabIndex = 12;
            this.btn_EditBook.Text = "Edit";
            this.btn_EditBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_EditBook.Click += new System.EventHandler(this.btn_EditBook_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btn_DeleteBook);
            this.gunaPanel1.Controls.Add(this.btn_EditBook);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.txt_BookTitle);
            this.gunaPanel1.Controls.Add(this.btn_AddBook);
            this.gunaPanel1.Controls.Add(this.txt_BookAuthor);
            this.gunaPanel1.Controls.Add(this.numeric_BookQty);
            this.gunaPanel1.Location = new System.Drawing.Point(420, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(556, 228);
            this.gunaPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // datagrid_Book
            // 
            this.datagrid_Book.AllowUserToAddRows = false;
            this.datagrid_Book.AllowUserToDeleteRows = false;
            this.datagrid_Book.AllowUserToResizeColumns = false;
            this.datagrid_Book.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid_Book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Book.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Book.ColumnHeadersHeight = 28;
            this.datagrid_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Book.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_Book.EnableHeadersVisualStyles = false;
            this.datagrid_Book.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Book.Location = new System.Drawing.Point(8, 274);
            this.datagrid_Book.Name = "datagrid_Book";
            this.datagrid_Book.RowHeadersVisible = false;
            this.datagrid_Book.RowHeadersWidth = 51;
            this.datagrid_Book.RowTemplate.Height = 24;
            this.datagrid_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Book.Size = new System.Drawing.Size(976, 350);
            this.datagrid_Book.TabIndex = 14;
            this.datagrid_Book.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagrid_Book.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Book.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Book.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Book.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Book.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Book.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Book.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Book.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Book.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Book.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Book.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Book.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Book.ThemeStyle.HeaderStyle.Height = 28;
            this.datagrid_Book.ThemeStyle.ReadOnly = false;
            this.datagrid_Book.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Book.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Book.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Book.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Book.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Book.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Book.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Book_CellContentClick);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(76, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(255, 158);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 15;
            this.gunaPictureBox1.TabStop = false;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(996, 636);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.datagrid_Book);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.txt_BookID);
            this.Controls.Add(this.txt_SearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUser";
            this.Load += new System.EventHandler(this.Book_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BookID;
        private Guna.UI.WinForms.GunaGradientButton btn_AddBook;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txt_BookAuthor;
        private Guna.UI.WinForms.GunaTextBox txt_BookTitle;
        private Guna.UI.WinForms.GunaTextBox txt_SearchBox;
        private Guna.UI.WinForms.GunaNumeric numeric_BookQty;
        private Guna.UI.WinForms.GunaGradientButton btn_EditBook;
        private Guna.UI.WinForms.GunaGradientButton btn_DeleteBook;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI.WinForms.GunaDataGridView datagrid_Book;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}