namespace goclinic.Forms
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new goclinic.customs.customTextBox();
            this.passwordTextBox = new goclinic.customs.customTextBox();
            this.signinButton = new goclinic.customs.CustomButton();
            this.openSignupButton = new goclinic.customs.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(240, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "ليس لديك حساب بعد؟";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(313, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(256, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "تسجيل الدخول";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "GoClinic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTextBox.Location = new System.Drawing.Point(60, 164);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.PlaceholderText = "اسم المستخدم";
            this.usernameTextBox.Radius = 30;
            this.usernameTextBox.Size = new System.Drawing.Size(500, 50);
            this.usernameTextBox.TabIndex = 20;
            this.usernameTextBox.TextAlignRight = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextBox.Location = new System.Drawing.Point(60, 254);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.PlaceholderText = "كلمة السر";
            this.passwordTextBox.Radius = 30;
            this.passwordTextBox.Size = new System.Drawing.Size(500, 50);
            this.passwordTextBox.TabIndex = 21;
            this.passwordTextBox.TextAlignRight = true;
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(141)))), ((int)(((byte)(145)))));
            this.signinButton.FlatAppearance.BorderSize = 0;
            this.signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinButton.ForeColor = System.Drawing.Color.White;
            this.signinButton.Location = new System.Drawing.Point(60, 340);
            this.signinButton.Name = "signinButton";
            this.signinButton.Radius = 20;
            this.signinButton.Size = new System.Drawing.Size(500, 40);
            this.signinButton.TabIndex = 22;
            this.signinButton.Text = "دخول";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.SigninButtonClick);
            // 
            // openSignupButton
            // 
            this.openSignupButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openSignupButton.FlatAppearance.BorderSize = 0;
            this.openSignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSignupButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openSignupButton.ForeColor = System.Drawing.Color.White;
            this.openSignupButton.Location = new System.Drawing.Point(180, 465);
            this.openSignupButton.Name = "openSignupButton";
            this.openSignupButton.Radius = 20;
            this.openSignupButton.Size = new System.Drawing.Size(248, 36);
            this.openSignupButton.TabIndex = 23;
            this.openSignupButton.Text = "تسجيل مستخدم جديد";
            this.openSignupButton.UseVisualStyleBackColor = false;
            this.openSignupButton.Click += new System.EventHandler(this.OpenSignupButtonClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(593, 564);
            this.Controls.Add(this.openSignupButton);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(611, 611);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private customs.customTextBox usernameTextBox;
        private customs.customTextBox passwordTextBox;
        private customs.CustomButton signinButton;
        private customs.CustomButton openSignupButton;
    }
}