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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btn_EditBook = new System.Windows.Forms.Button();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.txt_BookTitle = new System.Windows.Forms.TextBox();
            this.txt_BookAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_BookQty = new System.Windows.Forms.NumericUpDown();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.datagrid_Book = new System.Windows.Forms.DataGridView();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.btn_ex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BookQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(214, 171);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(82, 30);
            this.btn_AddBook.TabIndex = 0;
            this.btn_AddBook.Text = "Add";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_EditBook
            // 
            this.btn_EditBook.Location = new System.Drawing.Point(302, 171);
            this.btn_EditBook.Name = "btn_EditBook";
            this.btn_EditBook.Size = new System.Drawing.Size(82, 30);
            this.btn_EditBook.TabIndex = 0;
            this.btn_EditBook.Text = "Edit";
            this.btn_EditBook.UseVisualStyleBackColor = true;
            this.btn_EditBook.Click += new System.EventHandler(this.btn_EditBook_Click);
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.Location = new System.Drawing.Point(390, 171);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(82, 30);
            this.btn_DeleteBook.TabIndex = 0;
            this.btn_DeleteBook.Text = "Delete";
            this.btn_DeleteBook.UseVisualStyleBackColor = true;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // txt_BookTitle
            // 
            this.txt_BookTitle.Location = new System.Drawing.Point(42, 50);
            this.txt_BookTitle.Name = "txt_BookTitle";
            this.txt_BookTitle.Size = new System.Drawing.Size(272, 22);
            this.txt_BookTitle.TabIndex = 1;
            // 
            // txt_BookAuthor
            // 
            this.txt_BookAuthor.Location = new System.Drawing.Point(42, 104);
            this.txt_BookAuthor.Name = "txt_BookAuthor";
            this.txt_BookAuthor.Size = new System.Drawing.Size(272, 22);
            this.txt_BookAuthor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Author:";
            // 
            // numeric_BookQty
            // 
            this.numeric_BookQty.Location = new System.Drawing.Point(42, 141);
            this.numeric_BookQty.Name = "numeric_BookQty";
            this.numeric_BookQty.Size = new System.Drawing.Size(120, 22);
            this.numeric_BookQty.TabIndex = 3;
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.Location = new System.Drawing.Point(42, 179);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.Size = new System.Drawing.Size(153, 22);
            this.txt_SearchBox.TabIndex = 4;
            this.txt_SearchBox.Click += new System.EventHandler(this.txt_SearchBox_Click);
            this.txt_SearchBox.TextChanged += new System.EventHandler(this.txt_SearchBox_TextChanged);
            // 
            // datagrid_Book
            // 
            this.datagrid_Book.AllowUserToAddRows = false;
            this.datagrid_Book.AllowUserToDeleteRows = false;
            this.datagrid_Book.AllowUserToResizeColumns = false;
            this.datagrid_Book.AllowUserToResizeRows = false;
            this.datagrid_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Book.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagrid_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Book.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.datagrid_Book.Location = new System.Drawing.Point(42, 223);
            this.datagrid_Book.Name = "datagrid_Book";
            this.datagrid_Book.ReadOnly = true;
            this.datagrid_Book.RowHeadersVisible = false;
            this.datagrid_Book.RowHeadersWidth = 51;
            this.datagrid_Book.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_Book.RowTemplate.Height = 24;
            this.datagrid_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Book.Size = new System.Drawing.Size(498, 202);
            this.datagrid_Book.TabIndex = 5;
            this.datagrid_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Book_CellContentClick);
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(365, 22);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(125, 22);
            this.txt_BookID.TabIndex = 6;
            this.txt_BookID.Visible = false;
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(478, 171);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(82, 30);
            this.btn_ex.TabIndex = 7;
            this.btn_ex.Text = "Exit";
            this.btn_ex.UseVisualStyleBackColor = true;
            this.btn_ex.Click += new System.EventHandler(this.btn_ex_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.txt_BookID);
            this.Controls.Add(this.datagrid_Book);
            this.Controls.Add(this.txt_SearchBox);
            this.Controls.Add(this.numeric_BookQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BookAuthor);
            this.Controls.Add(this.txt_BookTitle);
            this.Controls.Add(this.btn_DeleteBook);
            this.Controls.Add(this.btn_EditBook);
            this.Controls.Add(this.btn_AddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUser";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BookQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btn_EditBook;
        private System.Windows.Forms.Button btn_DeleteBook;
        private System.Windows.Forms.TextBox txt_BookTitle;
        private System.Windows.Forms.TextBox txt_BookAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_BookQty;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private System.Windows.Forms.DataGridView datagrid_Book;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.Button btn_ex;
    }
}