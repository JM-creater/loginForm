﻿namespace loginForm.Forms
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Borrow = new Guna.UI.WinForms.GunaGradientButton();
            this.cb_Books = new Guna.UI.WinForms.GunaComboBox();
            this.cb_Borrowers = new Guna.UI.WinForms.GunaComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel3.Location = new System.Drawing.Point(121, 299);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(145, 23);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Borrower\'s Name:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(121, 189);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(89, 23);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Book Title:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(68, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(390, 60);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "BORROW FORM";
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.AnimationHoverSpeed = 0.07F;
            this.btn_Borrow.AnimationSpeed = 0.03F;
            this.btn_Borrow.BackColor = System.Drawing.Color.Transparent;
            this.btn_Borrow.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_Borrow.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_Borrow.BorderColor = System.Drawing.Color.Black;
            this.btn_Borrow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Borrow.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Borrow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrow.ForeColor = System.Drawing.Color.White;
            this.btn_Borrow.Image = null;
            this.btn_Borrow.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Borrow.Location = new System.Drawing.Point(182, 402);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.btn_Borrow.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.btn_Borrow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Borrow.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Borrow.OnHoverImage = null;
            this.btn_Borrow.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Borrow.Radius = 8;
            this.btn_Borrow.Size = new System.Drawing.Size(160, 42);
            this.btn_Borrow.TabIndex = 8;
            this.btn_Borrow.Text = "Borrow Book";
            this.btn_Borrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // cb_Books
            // 
            this.cb_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.cb_Books.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.cb_Books.BorderColor = System.Drawing.Color.Brown;
            this.cb_Books.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Books.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Books.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Books.ForeColor = System.Drawing.Color.White;
            this.cb_Books.FormattingEnabled = true;
            this.cb_Books.Location = new System.Drawing.Point(125, 215);
            this.cb_Books.Name = "cb_Books";
            this.cb_Books.OnHoverItemBaseColor = System.Drawing.Color.Brown;
            this.cb_Books.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_Books.Size = new System.Drawing.Size(265, 31);
            this.cb_Books.TabIndex = 5;
            // 
            // cb_Borrowers
            // 
            this.cb_Borrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.cb_Borrowers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.cb_Borrowers.BorderColor = System.Drawing.Color.Brown;
            this.cb_Borrowers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Borrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Borrowers.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Borrowers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Borrowers.ForeColor = System.Drawing.Color.White;
            this.cb_Borrowers.FormattingEnabled = true;
            this.cb_Borrowers.Location = new System.Drawing.Point(125, 325);
            this.cb_Borrowers.Name = "cb_Borrowers";
            this.cb_Borrowers.OnHoverItemBaseColor = System.Drawing.Color.Brown;
            this.cb_Borrowers.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_Borrowers.Size = new System.Drawing.Size(265, 31);
            this.cb_Borrowers.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::loginForm.Properties.Resources.Systems_and_technology_programming_company_logo__6_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(478, 137);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(494, 380);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 16;
            this.gunaPictureBox1.TabStop = false;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1001, 634);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_Borrow);
            this.Controls.Add(this.cb_Books);
            this.Controls.Add(this.cb_Borrowers);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowForm_FormClosing);
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton btn_Borrow;
        private Guna.UI.WinForms.GunaComboBox cb_Books;
        private Guna.UI.WinForms.GunaComboBox cb_Borrowers;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}