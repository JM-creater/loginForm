namespace loginForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShowHide = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_register = new System.Windows.Forms.LinkLabel();
            this.lbl_forgot = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_login = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(74, 393);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(266, 17);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(74, 467);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(266, 17);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(70, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // chkShowHide
            // 
            this.chkShowHide.AutoSize = true;
            this.chkShowHide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkShowHide.Location = new System.Drawing.Point(74, 509);
            this.chkShowHide.Name = "chkShowHide";
            this.chkShowHide.Size = new System.Drawing.Size(125, 20);
            this.chkShowHide.TabIndex = 3;
            this.chkShowHide.Text = "Show Password";
            this.chkShowHide.UseVisualStyleBackColor = true;
            this.chkShowHide.CheckedChanged += new System.EventHandler(this.chkShowHide_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(74, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(74, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 1);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Create New Account.";
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.BackColor = System.Drawing.Color.Transparent;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.LinkColor = System.Drawing.Color.IndianRed;
            this.lbl_register.Location = new System.Drawing.Point(262, 21);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(68, 20);
            this.lbl_register.TabIndex = 10;
            this.lbl_register.TabStop = true;
            this.lbl_register.Text = "Sign Up";
            this.lbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgot.LinkColor = System.Drawing.Color.IndianRed;
            this.lbl_forgot.Location = new System.Drawing.Point(195, 547);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(145, 20);
            this.lbl_forgot.TabIndex = 11;
            this.lbl_forgot.TabStop = true;
            this.lbl_forgot.Text = "Forgot Password?";
            this.lbl_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(123, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 60);
            this.label5.TabIndex = 2;
            this.label5.Text = "LOGIN";
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(373, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.pictureBox3);
            this.gunaGradientPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(421, 250);
            this.gunaGradientPanel1.TabIndex = 13;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(31, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(362, 202);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 13;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_login.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = null;
            this.btn_login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_login.Location = new System.Drawing.Point(74, 598);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_login.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_login.Radius = 8;
            this.btn_login.Size = new System.Drawing.Size(266, 42);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOGIN";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.label4);
            this.gunaGradientPanel2.Controls.Add(this.lbl_register);
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 664);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(421, 200);
            this.gunaGradientPanel2.TabIndex = 15;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(421, 729);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.lbl_forgot);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkShowHide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowHide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbl_register;
        private System.Windows.Forms.LinkLabel lbl_forgot;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaGradientButton btn_login;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

