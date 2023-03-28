namespace loginForm.Forms
{
    partial class ReturnForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Return = new Guna.UI.WinForms.GunaButton();
            this.datagrid_Transaction = new Guna.UI.WinForms.GunaDataGridView();
            this.txt_IsReturned = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_BookTitle = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Fullname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(407, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Book Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Full Name";
            // 
            // btn_Return
            // 
            this.btn_Return.AnimationHoverSpeed = 0.07F;
            this.btn_Return.AnimationSpeed = 0.03F;
            this.btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.btn_Return.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_Return.BorderColor = System.Drawing.Color.Black;
            this.btn_Return.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Return.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Image = null;
            this.btn_Return.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Return.Location = new System.Drawing.Point(757, 197);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_Return.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_Return.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Return.OnHoverImage = null;
            this.btn_Return.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Return.Radius = 8;
            this.btn_Return.Size = new System.Drawing.Size(160, 42);
            this.btn_Return.TabIndex = 18;
            this.btn_Return.Text = "Return Book";
            this.btn_Return.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // datagrid_Transaction
            // 
            this.datagrid_Transaction.AllowUserToAddRows = false;
            this.datagrid_Transaction.AllowUserToDeleteRows = false;
            this.datagrid_Transaction.AllowUserToResizeColumns = false;
            this.datagrid_Transaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.datagrid_Transaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.datagrid_Transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Transaction.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Transaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Transaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.datagrid_Transaction.ColumnHeadersHeight = 28;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Transaction.DefaultCellStyle = dataGridViewCellStyle21;
            this.datagrid_Transaction.EnableHeadersVisualStyles = false;
            this.datagrid_Transaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Transaction.Location = new System.Drawing.Point(12, 245);
            this.datagrid_Transaction.Name = "datagrid_Transaction";
            this.datagrid_Transaction.ReadOnly = true;
            this.datagrid_Transaction.RowHeadersVisible = false;
            this.datagrid_Transaction.RowHeadersWidth = 51;
            this.datagrid_Transaction.RowTemplate.Height = 24;
            this.datagrid_Transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Transaction.Size = new System.Drawing.Size(924, 293);
            this.datagrid_Transaction.TabIndex = 17;
            this.datagrid_Transaction.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagrid_Transaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Transaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Transaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Transaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Transaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Transaction.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Transaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.Height = 28;
            this.datagrid_Transaction.ThemeStyle.ReadOnly = true;
            this.datagrid_Transaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Transaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Transaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Transaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Transaction.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Transaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Transaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Transaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Transaction_CellContentClick);
            // 
            // txt_IsReturned
            // 
            this.txt_IsReturned.Location = new System.Drawing.Point(812, 40);
            this.txt_IsReturned.Name = "txt_IsReturned";
            this.txt_IsReturned.Size = new System.Drawing.Size(124, 22);
            this.txt_IsReturned.TabIndex = 15;
            this.txt_IsReturned.Visible = false;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(812, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(124, 22);
            this.txt_ID.TabIndex = 16;
            this.txt_ID.Visible = false;
            // 
            // txt_BookTitle
            // 
            this.txt_BookTitle.BaseColor = System.Drawing.Color.White;
            this.txt_BookTitle.BorderColor = System.Drawing.Color.Silver;
            this.txt_BookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BookTitle.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_BookTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_BookTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_BookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_BookTitle.Location = new System.Drawing.Point(411, 139);
            this.txt_BookTitle.Name = "txt_BookTitle";
            this.txt_BookTitle.PasswordChar = '\0';
            this.txt_BookTitle.SelectedText = "";
            this.txt_BookTitle.Size = new System.Drawing.Size(280, 32);
            this.txt_BookTitle.TabIndex = 13;
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.BaseColor = System.Drawing.Color.White;
            this.txt_Fullname.BorderColor = System.Drawing.Color.Silver;
            this.txt_Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fullname.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Fullname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Fullname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Fullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Fullname.Location = new System.Drawing.Point(96, 139);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.PasswordChar = '\0';
            this.txt_Fullname.SelectedText = "";
            this.txt_Fullname.Size = new System.Drawing.Size(280, 32);
            this.txt_Fullname.TabIndex = 14;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(18, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(411, 60);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "RETURN BOOKS";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(948, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.datagrid_Transaction);
            this.Controls.Add(this.txt_IsReturned);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_BookTitle);
            this.Controls.Add(this.txt_Fullname);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnForm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btn_Return;
        private Guna.UI.WinForms.GunaDataGridView datagrid_Transaction;
        private System.Windows.Forms.TextBox txt_IsReturned;
        private System.Windows.Forms.TextBox txt_ID;
        private Guna.UI.WinForms.GunaTextBox txt_BookTitle;
        private Guna.UI.WinForms.GunaTextBox txt_Fullname;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}