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
            this.materialEnter = new MaterialSkin.Controls.MaterialButton();
            this.materialUser = new MaterialSkin.Controls.MaterialTextBox();
            this.materialPass = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialEnter
            // 
            this.materialEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialEnter.Depth = 0;
            this.materialEnter.HighEmphasis = true;
            this.materialEnter.Icon = null;
            this.materialEnter.Location = new System.Drawing.Point(49, 333);
            this.materialEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialEnter.Name = "materialEnter";
            this.materialEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialEnter.Size = new System.Drawing.Size(67, 36);
            this.materialEnter.TabIndex = 0;
            this.materialEnter.Text = "Enter";
            this.materialEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialEnter.UseAccentColor = false;
            this.materialEnter.UseVisualStyleBackColor = true;
            this.materialEnter.Click += new System.EventHandler(this.materialEnter_Click);
            // 
            // materialUser
            // 
            this.materialUser.AnimateReadOnly = false;
            this.materialUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialUser.Depth = 0;
            this.materialUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialUser.LeadingIcon = null;
            this.materialUser.Location = new System.Drawing.Point(49, 150);
            this.materialUser.MaxLength = 50;
            this.materialUser.MouseState = MaterialSkin.MouseState.OUT;
            this.materialUser.Multiline = false;
            this.materialUser.Name = "materialUser";
            this.materialUser.Size = new System.Drawing.Size(218, 50);
            this.materialUser.TabIndex = 2;
            this.materialUser.Text = "";
            this.materialUser.TrailingIcon = null;
            // 
            // materialPass
            // 
            this.materialPass.AnimateReadOnly = false;
            this.materialPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialPass.Depth = 0;
            this.materialPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialPass.LeadingIcon = null;
            this.materialPass.Location = new System.Drawing.Point(49, 228);
            this.materialPass.MaxLength = 50;
            this.materialPass.MouseState = MaterialSkin.MouseState.OUT;
            this.materialPass.Multiline = false;
            this.materialPass.Name = "materialPass";
            this.materialPass.Size = new System.Drawing.Size(218, 50);
            this.materialPass.TabIndex = 2;
            this.materialPass.Text = "";
            this.materialPass.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(172, 333);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "CANCEL";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter your username";
            // 
            // forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialPass);
            this.Controls.Add(this.materialUser);
            this.Controls.Add(this.materialEnter);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "forgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialEnter;
        private MaterialSkin.Controls.MaterialTextBox materialUser;
        private MaterialSkin.Controls.MaterialTextBox materialPass;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label label1;
    }
}