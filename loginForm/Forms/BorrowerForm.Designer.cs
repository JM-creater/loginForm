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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowerForm));
            this.txt_BorrowerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Firstname = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Lastname = new Guna.UI.WinForms.GunaTextBox();
            this.txt_FnameSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagrid_Borrower = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_UpdateBorrower = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_EditBorrower = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_AddBorrower = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Borrower)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BorrowerID
            // 
            this.txt_BorrowerID.Location = new System.Drawing.Point(784, 262);
            this.txt_BorrowerID.Name = "txt_BorrowerID";
            this.txt_BorrowerID.Size = new System.Drawing.Size(131, 22);
            this.txt_BorrowerID.TabIndex = 0;
            this.txt_BorrowerID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.BackColor = System.Drawing.Color.Transparent;
            this.txt_Firstname.BaseColor = System.Drawing.Color.White;
            this.txt_Firstname.BorderColor = System.Drawing.Color.Silver;
            this.txt_Firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Firstname.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Firstname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Firstname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Firstname.Location = new System.Drawing.Point(26, 45);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.PasswordChar = '\0';
            this.txt_Firstname.Radius = 8;
            this.txt_Firstname.SelectedText = "";
            this.txt_Firstname.Size = new System.Drawing.Size(247, 32);
            this.txt_Firstname.TabIndex = 5;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.BackColor = System.Drawing.Color.Transparent;
            this.txt_Lastname.BaseColor = System.Drawing.Color.White;
            this.txt_Lastname.BorderColor = System.Drawing.Color.Silver;
            this.txt_Lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Lastname.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Lastname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Lastname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Lastname.Location = new System.Drawing.Point(292, 45);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.PasswordChar = '\0';
            this.txt_Lastname.Radius = 8;
            this.txt_Lastname.SelectedText = "";
            this.txt_Lastname.Size = new System.Drawing.Size(226, 32);
            this.txt_Lastname.TabIndex = 5;
            // 
            // txt_FnameSearch
            // 
            this.txt_FnameSearch.BackColor = System.Drawing.Color.Transparent;
            this.txt_FnameSearch.BaseColor = System.Drawing.Color.White;
            this.txt_FnameSearch.BorderColor = System.Drawing.Color.Silver;
            this.txt_FnameSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FnameSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_FnameSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FnameSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_FnameSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_FnameSearch.Location = new System.Drawing.Point(12, 241);
            this.txt_FnameSearch.Name = "txt_FnameSearch";
            this.txt_FnameSearch.PasswordChar = '\0';
            this.txt_FnameSearch.Radius = 8;
            this.txt_FnameSearch.SelectedText = "";
            this.txt_FnameSearch.Size = new System.Drawing.Size(284, 32);
            this.txt_FnameSearch.TabIndex = 5;
            this.txt_FnameSearch.TextChanged += new System.EventHandler(this.txt_FnameSearch_TextChanged);
            this.txt_FnameSearch.Click += new System.EventHandler(this.txt_FnameSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search";
            // 
            // datagrid_Borrower
            // 
            this.datagrid_Borrower.AllowUserToAddRows = false;
            this.datagrid_Borrower.AllowUserToDeleteRows = false;
            this.datagrid_Borrower.AllowUserToResizeColumns = false;
            this.datagrid_Borrower.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid_Borrower.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Borrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Borrower.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Borrower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Borrower.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Borrower.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagrid_Borrower.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Borrower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Borrower.ColumnHeadersHeight = 28;
            this.datagrid_Borrower.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Borrower.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_Borrower.EnableHeadersVisualStyles = false;
            this.datagrid_Borrower.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Borrower.Location = new System.Drawing.Point(12, 290);
            this.datagrid_Borrower.Name = "datagrid_Borrower";
            this.datagrid_Borrower.ReadOnly = true;
            this.datagrid_Borrower.RowHeadersVisible = false;
            this.datagrid_Borrower.RowHeadersWidth = 51;
            this.datagrid_Borrower.RowTemplate.Height = 24;
            this.datagrid_Borrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Borrower.Size = new System.Drawing.Size(903, 334);
            this.datagrid_Borrower.TabIndex = 7;
            this.datagrid_Borrower.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagrid_Borrower.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Borrower.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Borrower.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Borrower.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Borrower.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Borrower.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Borrower.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Borrower.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Borrower.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Borrower.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Borrower.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Borrower.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Borrower.ThemeStyle.HeaderStyle.Height = 28;
            this.datagrid_Borrower.ThemeStyle.ReadOnly = true;
            this.datagrid_Borrower.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Borrower.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Borrower.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Borrower.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Borrower.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Borrower.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Borrower.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Borrower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Borrower_CellContentClick);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.btn_UpdateBorrower);
            this.gunaPanel1.Controls.Add(this.btn_EditBorrower);
            this.gunaPanel1.Controls.Add(this.txt_Firstname);
            this.gunaPanel1.Controls.Add(this.btn_AddBorrower);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.txt_Lastname);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(586, 200);
            this.gunaPanel1.TabIndex = 8;
            // 
            // btn_UpdateBorrower
            // 
            this.btn_UpdateBorrower.AnimationHoverSpeed = 0.07F;
            this.btn_UpdateBorrower.AnimationSpeed = 0.03F;
            this.btn_UpdateBorrower.BackColor = System.Drawing.Color.Transparent;
            this.btn_UpdateBorrower.BaseColor1 = System.Drawing.Color.Red;
            this.btn_UpdateBorrower.BaseColor2 = System.Drawing.Color.Red;
            this.btn_UpdateBorrower.BorderColor = System.Drawing.Color.Red;
            this.btn_UpdateBorrower.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_UpdateBorrower.FocusedColor = System.Drawing.Color.Empty;
            this.btn_UpdateBorrower.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_UpdateBorrower.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateBorrower.Image = null;
            this.btn_UpdateBorrower.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_UpdateBorrower.Location = new System.Drawing.Point(388, 112);
            this.btn_UpdateBorrower.Name = "btn_UpdateBorrower";
            this.btn_UpdateBorrower.OnHoverBaseColor1 = System.Drawing.Color.Salmon;
            this.btn_UpdateBorrower.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btn_UpdateBorrower.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_UpdateBorrower.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_UpdateBorrower.OnHoverImage = null;
            this.btn_UpdateBorrower.OnPressedColor = System.Drawing.Color.Black;
            this.btn_UpdateBorrower.Radius = 8;
            this.btn_UpdateBorrower.Size = new System.Drawing.Size(160, 42);
            this.btn_UpdateBorrower.TabIndex = 15;
            this.btn_UpdateBorrower.Text = "Delete";
            this.btn_UpdateBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_UpdateBorrower.Click += new System.EventHandler(this.btn_UpdateBorrower_Click);
            // 
            // btn_EditBorrower
            // 
            this.btn_EditBorrower.AnimationHoverSpeed = 0.07F;
            this.btn_EditBorrower.AnimationSpeed = 0.03F;
            this.btn_EditBorrower.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditBorrower.BaseColor1 = System.Drawing.Color.RoyalBlue;
            this.btn_EditBorrower.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.btn_EditBorrower.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditBorrower.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_EditBorrower.FocusedColor = System.Drawing.Color.Empty;
            this.btn_EditBorrower.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditBorrower.ForeColor = System.Drawing.Color.White;
            this.btn_EditBorrower.Image = null;
            this.btn_EditBorrower.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_EditBorrower.Location = new System.Drawing.Point(207, 112);
            this.btn_EditBorrower.Name = "btn_EditBorrower";
            this.btn_EditBorrower.OnHoverBaseColor1 = System.Drawing.Color.LightSkyBlue;
            this.btn_EditBorrower.OnHoverBaseColor2 = System.Drawing.Color.LightSkyBlue;
            this.btn_EditBorrower.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_EditBorrower.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_EditBorrower.OnHoverImage = null;
            this.btn_EditBorrower.OnPressedColor = System.Drawing.Color.Black;
            this.btn_EditBorrower.Radius = 8;
            this.btn_EditBorrower.Size = new System.Drawing.Size(160, 42);
            this.btn_EditBorrower.TabIndex = 14;
            this.btn_EditBorrower.Text = "Edit";
            this.btn_EditBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_EditBorrower.Click += new System.EventHandler(this.btn_EditBorrower_Click);
            // 
            // btn_AddBorrower
            // 
            this.btn_AddBorrower.AnimationHoverSpeed = 0.07F;
            this.btn_AddBorrower.AnimationSpeed = 0.03F;
            this.btn_AddBorrower.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddBorrower.BaseColor1 = System.Drawing.Color.LimeGreen;
            this.btn_AddBorrower.BaseColor2 = System.Drawing.Color.LimeGreen;
            this.btn_AddBorrower.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_AddBorrower.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddBorrower.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddBorrower.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBorrower.ForeColor = System.Drawing.Color.White;
            this.btn_AddBorrower.Image = null;
            this.btn_AddBorrower.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddBorrower.Location = new System.Drawing.Point(26, 112);
            this.btn_AddBorrower.Name = "btn_AddBorrower";
            this.btn_AddBorrower.OnHoverBaseColor1 = System.Drawing.Color.Chartreuse;
            this.btn_AddBorrower.OnHoverBaseColor2 = System.Drawing.Color.Chartreuse;
            this.btn_AddBorrower.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_AddBorrower.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AddBorrower.OnHoverImage = null;
            this.btn_AddBorrower.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AddBorrower.Radius = 8;
            this.btn_AddBorrower.Size = new System.Drawing.Size(160, 42);
            this.btn_AddBorrower.TabIndex = 13;
            this.btn_AddBorrower.Text = "Add";
            this.btn_AddBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddBorrower.Click += new System.EventHandler(this.btn_AddBorrower_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(638, 24);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(255, 158);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 16;
            this.gunaPictureBox1.TabStop = false;
            // 
            // BorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(927, 636);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.datagrid_Borrower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_FnameSearch);
            this.Controls.Add(this.txt_BorrowerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowerForm_FormClosing);
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Borrower)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_BorrowerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_Firstname;
        private Guna.UI.WinForms.GunaTextBox txt_Lastname;
        private Guna.UI.WinForms.GunaTextBox txt_FnameSearch;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView datagrid_Borrower;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGradientButton btn_UpdateBorrower;
        private Guna.UI.WinForms.GunaGradientButton btn_EditBorrower;
        private Guna.UI.WinForms.GunaGradientButton btn_AddBorrower;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}