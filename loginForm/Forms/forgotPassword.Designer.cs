namespace loginForm.Forms
{
    partial class forgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaEnter = new Guna.UI.WinForms.GunaButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter your username";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(406, 225);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaUser
            // 
            this.gunaUser.BackColor = System.Drawing.Color.Transparent;
            this.gunaUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.gunaUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.gunaUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaUser.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.gunaUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.gunaUser.FocusedForeColor = System.Drawing.Color.White;
            this.gunaUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaUser.ForeColor = System.Drawing.Color.White;
            this.gunaUser.Location = new System.Drawing.Point(70, 292);
            this.gunaUser.Name = "gunaUser";
            this.gunaUser.PasswordChar = '\0';
            this.gunaUser.Radius = 8;
            this.gunaUser.SelectedText = "";
            this.gunaUser.Size = new System.Drawing.Size(271, 46);
            this.gunaUser.TabIndex = 1;
            // 
            // gunaPass
            // 
            this.gunaPass.BackColor = System.Drawing.Color.Transparent;
            this.gunaPass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.gunaPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.gunaPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaPass.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.gunaPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.gunaPass.FocusedForeColor = System.Drawing.Color.White;
            this.gunaPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaPass.ForeColor = System.Drawing.Color.White;
            this.gunaPass.Location = new System.Drawing.Point(70, 357);
            this.gunaPass.Name = "gunaPass";
            this.gunaPass.PasswordChar = '\0';
            this.gunaPass.Radius = 8;
            this.gunaPass.SelectedText = "";
            this.gunaPass.Size = new System.Drawing.Size(271, 46);
            this.gunaPass.TabIndex = 2;
            // 
            // gunaEnter
            // 
            this.gunaEnter.AnimationHoverSpeed = 0.07F;
            this.gunaEnter.AnimationSpeed = 0.03F;
            this.gunaEnter.BackColor = System.Drawing.Color.Transparent;
            this.gunaEnter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.gunaEnter.BorderColor = System.Drawing.Color.Black;
            this.gunaEnter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaEnter.FocusedColor = System.Drawing.Color.Empty;
            this.gunaEnter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaEnter.ForeColor = System.Drawing.Color.White;
            this.gunaEnter.Image = null;
            this.gunaEnter.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaEnter.Location = new System.Drawing.Point(98, 420);
            this.gunaEnter.Name = "gunaEnter";
            this.gunaEnter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.gunaEnter.OnHoverBorderColor = System.Drawing.Color.Red;
            this.gunaEnter.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaEnter.OnHoverImage = null;
            this.gunaEnter.OnPressedColor = System.Drawing.Color.Black;
            this.gunaEnter.Radius = 15;
            this.gunaEnter.Size = new System.Drawing.Size(216, 45);
            this.gunaEnter.TabIndex = 3;
            this.gunaEnter.Text = "Enter";
            this.gunaEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaEnter.Click += new System.EventHandler(this.gunaEnter_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(358, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(406, 494);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gunaEnter);
            this.Controls.Add(this.gunaPass);
            this.Controls.Add(this.gunaUser);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox gunaUser;
        private Guna.UI.WinForms.GunaTextBox gunaPass;
        private Guna.UI.WinForms.GunaButton gunaEnter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}