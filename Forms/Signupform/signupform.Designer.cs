namespace goclinic.Forms
{
    partial class تسجيل
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(تسجيل));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTextBox = new goclinic.customs.customTextBox();
            this.numberTextBox = new goclinic.customs.customTextBox();
            this.passwordTextBox = new goclinic.customs.customTextBox();
            this.createUserButton = new goclinic.customs.CustomButton();
            this.openLoginButton = new goclinic.customs.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "GoClinic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(197, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(365, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "تسجيل مستخدم جديد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(243, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "من فضلك قم بملئ الاستمارة الأتية لإنشاء حساب جديد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(240, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "لديك حساب بالفعل؟";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTextBox.Location = new System.Drawing.Point(62, 168);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.PlaceholderText = "اسم المستخدم الجديد";
            this.usernameTextBox.Radius = 30;
            this.usernameTextBox.Size = new System.Drawing.Size(500, 50);
            this.usernameTextBox.TabIndex = 10;
            this.usernameTextBox.TextAlignRight = true;
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.numberTextBox.Location = new System.Drawing.Point(62, 255);
            this.numberTextBox.Multiline = false;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.numberTextBox.PasswordChar = false;
            this.numberTextBox.PlaceholderText = "رقم الموبايل او بريد الكتروني";
            this.numberTextBox.Radius = 30;
            this.numberTextBox.Size = new System.Drawing.Size(500, 50);
            this.numberTextBox.TabIndex = 11;
            this.numberTextBox.TextAlignRight = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextBox.Location = new System.Drawing.Point(60, 338);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.PlaceholderText = "كلمة السر";
            this.passwordTextBox.Radius = 30;
            this.passwordTextBox.Size = new System.Drawing.Size(500, 50);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.TextAlignRight = true;
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(141)))), ((int)(((byte)(145)))));
            this.createUserButton.FlatAppearance.BorderSize = 0;
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createUserButton.ForeColor = System.Drawing.Color.White;
            this.createUserButton.Location = new System.Drawing.Point(62, 411);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Radius = 20;
            this.createUserButton.Size = new System.Drawing.Size(500, 40);
            this.createUserButton.TabIndex = 23;
            this.createUserButton.Text = "تسجيل مستخدم جديد";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.CreateUserButtonClick);
            // 
            // openLoginButton
            // 
            this.openLoginButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openLoginButton.FlatAppearance.BorderSize = 0;
            this.openLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openLoginButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openLoginButton.ForeColor = System.Drawing.Color.White;
            this.openLoginButton.Location = new System.Drawing.Point(187, 505);
            this.openLoginButton.Name = "openLoginButton";
            this.openLoginButton.Radius = 20;
            this.openLoginButton.Size = new System.Drawing.Size(248, 36);
            this.openLoginButton.TabIndex = 24;
            this.openLoginButton.Text = "تسجيل الدخول";
            this.openLoginButton.UseVisualStyleBackColor = false;
            this.openLoginButton.Click += new System.EventHandler(this.OpenLoginButtonClick);
            // 
            // تسجيل
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(593, 564);
            this.Controls.Add(this.openLoginButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(611, 611);
            this.Name = "تسجيل";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signupform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private customs.customTextBox usernameTextBox;
        private customs.customTextBox numberTextBox;
        private customs.customTextBox passwordTextBox;
        private customs.CustomButton createUserButton;
        private customs.CustomButton openLoginButton;
    }
}