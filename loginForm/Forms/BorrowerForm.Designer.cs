namespace loginForm
{
    partial class BorrowerForm
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
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_FnameSearch = new System.Windows.Forms.TextBox();
            this.txt_BorrowerID = new System.Windows.Forms.TextBox();
            this.datagrid_Borrower = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddBorrower = new System.Windows.Forms.Button();
            this.btn_UpdateBorrower = new System.Windows.Forms.Button();
            this.btn_EditBorrower = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Borrower)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(40, 50);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(243, 22);
            this.txt_Firstname.TabIndex = 0;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(308, 50);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(243, 22);
            this.txt_Lastname.TabIndex = 0;
            // 
            // txt_FnameSearch
            // 
            this.txt_FnameSearch.Location = new System.Drawing.Point(40, 104);
            this.txt_FnameSearch.Name = "txt_FnameSearch";
            this.txt_FnameSearch.Size = new System.Drawing.Size(243, 22);
            this.txt_FnameSearch.TabIndex = 0;
            this.txt_FnameSearch.Click += new System.EventHandler(this.txt_FnameSearch_Click);
            this.txt_FnameSearch.TextChanged += new System.EventHandler(this.txt_FnameSearch_TextChanged);
            // 
            // txt_BorrowerID
            // 
            this.txt_BorrowerID.Location = new System.Drawing.Point(561, 12);
            this.txt_BorrowerID.Name = "txt_BorrowerID";
            this.txt_BorrowerID.Size = new System.Drawing.Size(100, 22);
            this.txt_BorrowerID.TabIndex = 0;
            this.txt_BorrowerID.Visible = false;
            // 
            // datagrid_Borrower
            // 
            this.datagrid_Borrower.AllowUserToAddRows = false;
            this.datagrid_Borrower.AllowUserToDeleteRows = false;
            this.datagrid_Borrower.AllowUserToResizeColumns = false;
            this.datagrid_Borrower.AllowUserToResizeRows = false;
            this.datagrid_Borrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Borrower.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagrid_Borrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Borrower.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.datagrid_Borrower.Location = new System.Drawing.Point(40, 154);
            this.datagrid_Borrower.Name = "datagrid_Borrower";
            this.datagrid_Borrower.ReadOnly = true;
            this.datagrid_Borrower.RowHeadersVisible = false;
            this.datagrid_Borrower.RowHeadersWidth = 51;
            this.datagrid_Borrower.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_Borrower.RowTemplate.Height = 24;
            this.datagrid_Borrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Borrower.Size = new System.Drawing.Size(588, 253);
            this.datagrid_Borrower.TabIndex = 1;
            this.datagrid_Borrower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Borrower_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // btn_AddBorrower
            // 
            this.btn_AddBorrower.Location = new System.Drawing.Point(310, 96);
            this.btn_AddBorrower.Name = "btn_AddBorrower";
            this.btn_AddBorrower.Size = new System.Drawing.Size(89, 30);
            this.btn_AddBorrower.TabIndex = 3;
            this.btn_AddBorrower.Text = "Add";
            this.btn_AddBorrower.UseVisualStyleBackColor = true;
            this.btn_AddBorrower.Click += new System.EventHandler(this.btn_AddBorrower_Click);
            // 
            // btn_UpdateBorrower
            // 
            this.btn_UpdateBorrower.Location = new System.Drawing.Point(500, 96);
            this.btn_UpdateBorrower.Name = "btn_UpdateBorrower";
            this.btn_UpdateBorrower.Size = new System.Drawing.Size(89, 30);
            this.btn_UpdateBorrower.TabIndex = 3;
            this.btn_UpdateBorrower.Text = "Delete";
            this.btn_UpdateBorrower.UseVisualStyleBackColor = true;
            this.btn_UpdateBorrower.Click += new System.EventHandler(this.btn_UpdateBorrower_Click);
            // 
            // btn_EditBorrower
            // 
            this.btn_EditBorrower.Location = new System.Drawing.Point(405, 96);
            this.btn_EditBorrower.Name = "btn_EditBorrower";
            this.btn_EditBorrower.Size = new System.Drawing.Size(89, 30);
            this.btn_EditBorrower.TabIndex = 3;
            this.btn_EditBorrower.Text = "Edit";
            this.btn_EditBorrower.UseVisualStyleBackColor = true;
            this.btn_EditBorrower.Click += new System.EventHandler(this.btn_EditBorrower_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(595, 96);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(89, 30);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Exit";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // BorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 425);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_EditBorrower);
            this.Controls.Add(this.btn_UpdateBorrower);
            this.Controls.Add(this.btn_AddBorrower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_Borrower);
            this.Controls.Add(this.txt_BorrowerID);
            this.Controls.Add(this.txt_FnameSearch);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Name = "BorrowerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Borrower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_FnameSearch;
        private System.Windows.Forms.TextBox txt_BorrowerID;
        private System.Windows.Forms.DataGridView datagrid_Borrower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddBorrower;
        private System.Windows.Forms.Button btn_UpdateBorrower;
        private System.Windows.Forms.Button btn_EditBorrower;
        private System.Windows.Forms.Button btn_Close;
    }
}