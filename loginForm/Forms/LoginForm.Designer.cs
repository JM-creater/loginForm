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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShowHide = new System.Windows.Forms.CheckBox();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.txt_Retrieve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(168, 277);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 33);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(297, 277);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(89, 33);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(162, 108);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(287, 22);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(162, 167);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(287, 22);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // chkShowHide
            // 
            this.chkShowHide.AutoSize = true;
            this.chkShowHide.Location = new System.Drawing.Point(162, 217);
            this.chkShowHide.Name = "chkShowHide";
            this.chkShowHide.Size = new System.Drawing.Size(125, 20);
            this.chkShowHide.TabIndex = 3;
            this.chkShowHide.Text = "Show Password";
            this.chkShowHide.UseVisualStyleBackColor = true;
            this.chkShowHide.CheckedChanged += new System.EventHandler(this.chkShowHide_CheckedChanged);
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(71, 328);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(186, 33);
            this.btn_retrieve.TabIndex = 4;
            this.btn_retrieve.Text = "Forgot Password";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Retrieve
            // 
            this.txt_Retrieve.Location = new System.Drawing.Point(297, 333);
            this.txt_Retrieve.Name = "txt_Retrieve";
            this.txt_Retrieve.Size = new System.Drawing.Size(140, 22);
            this.txt_Retrieve.TabIndex = 5;
            this.txt_Retrieve.Visible = false;
            // 
            // bunifuButton1
            // 
            
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 457);
            this.Controls.Add(this.txt_Retrieve);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.chkShowHide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowHide;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.TextBox txt_Retrieve;
    }
}

