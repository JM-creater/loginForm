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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Fullname = new Guna.UI.WinForms.GunaTextBox();
            this.txt_BookTitle = new Guna.UI.WinForms.GunaTextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_IsReturned = new System.Windows.Forms.TextBox();
            this.datagrid_Transaction = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_Return = new Guna.UI.WinForms.GunaButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(411, 60);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "RETURN BOOKS";
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
            this.txt_Fullname.Location = new System.Drawing.Point(129, 89);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.PasswordChar = '\0';
            this.txt_Fullname.SelectedText = "";
            this.txt_Fullname.Size = new System.Drawing.Size(206, 32);
            this.txt_Fullname.TabIndex = 6;
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
            this.txt_BookTitle.Location = new System.Drawing.Point(396, 89);
            this.txt_BookTitle.Name = "txt_BookTitle";
            this.txt_BookTitle.PasswordChar = '\0';
            this.txt_BookTitle.SelectedText = "";
            this.txt_BookTitle.Size = new System.Drawing.Size(206, 32);
            this.txt_BookTitle.TabIndex = 6;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(641, 24);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(124, 22);
            this.txt_ID.TabIndex = 7;
            this.txt_ID.Visible = false;
            // 
            // txt_IsReturned
            // 
            this.txt_IsReturned.Location = new System.Drawing.Point(641, 52);
            this.txt_IsReturned.Name = "txt_IsReturned";
            this.txt_IsReturned.Size = new System.Drawing.Size(124, 22);
            this.txt_IsReturned.TabIndex = 7;
            this.txt_IsReturned.Visible = false;
            // 
            // datagrid_Transaction
            // 
            this.datagrid_Transaction.AllowUserToAddRows = false;
            this.datagrid_Transaction.AllowUserToDeleteRows = false;
            this.datagrid_Transaction.AllowUserToResizeColumns = false;
            this.datagrid_Transaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.datagrid_Transaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.datagrid_Transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Transaction.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Transaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Transaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.datagrid_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Transaction.DefaultCellStyle = dataGridViewCellStyle15;
            this.datagrid_Transaction.EnableHeadersVisualStyles = false;
            this.datagrid_Transaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Transaction.Location = new System.Drawing.Point(12, 193);
            this.datagrid_Transaction.Name = "datagrid_Transaction";
            this.datagrid_Transaction.ReadOnly = true;
            this.datagrid_Transaction.RowHeadersVisible = false;
            this.datagrid_Transaction.RowHeadersWidth = 51;
            this.datagrid_Transaction.RowTemplate.Height = 24;
            this.datagrid_Transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Transaction.Size = new System.Drawing.Size(776, 245);
            this.datagrid_Transaction.TabIndex = 8;
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
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Transaction.ThemeStyle.HeaderStyle.Height = 4;
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
            // btn_Return
            // 
            this.btn_Return.AnimationHoverSpeed = 0.07F;
            this.btn_Return.AnimationSpeed = 0.03F;
            this.btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.btn_Return.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Return.BorderColor = System.Drawing.Color.Black;
            this.btn_Return.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Return.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Image = null;
            this.btn_Return.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Return.Location = new System.Drawing.Point(129, 136);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Return.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Return.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Return.OnHoverImage = null;
            this.btn_Return.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Return.Radius = 8;
            this.btn_Return.Size = new System.Drawing.Size(160, 42);
            this.btn_Return.TabIndex = 9;
            this.btn_Return.Text = "Return Book";
            this.btn_Return.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.datagrid_Transaction);
            this.Controls.Add(this.txt_IsReturned);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_BookTitle);
            this.Controls.Add(this.txt_Fullname);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnForm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TextBox txt_IsReturned;
        private System.Windows.Forms.TextBox txt_ID;
        private Guna.UI.WinForms.GunaTextBox txt_BookTitle;
        private Guna.UI.WinForms.GunaTextBox txt_Fullname;
        private Guna.UI.WinForms.GunaButton btn_Return;
        private Guna.UI.WinForms.GunaDataGridView datagrid_Transaction;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}