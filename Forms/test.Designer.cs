namespace goclinic.Forms
{
    partial class test
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
            this.customTextBox1 = new goclinic.customs.customTextBox();
            this.customTextBox2 = new goclinic.customs.customTextBox();
            this.customTextBox3 = new goclinic.customs.customTextBox();
            this.customTextBox4 = new goclinic.customs.customTextBox();
            this.customButton1 = new goclinic.customs.CustomButton();
            this.SuspendLayout();
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(21, 12);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderText = "this is a place holder";
            this.customTextBox1.Radius = 1;
            this.customTextBox1.Size = new System.Drawing.Size(430, 41);
            this.customTextBox1.TabIndex = 0;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(315, 68);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10);
            this.customTextBox2.PasswordChar = true;
            this.customTextBox2.PlaceholderText = "this is a place holder";
            this.customTextBox2.Radius = 5;
            this.customTextBox2.Size = new System.Drawing.Size(430, 41);
            this.customTextBox2.TabIndex = 1;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(44, 115);
            this.customTextBox3.Multiline = true;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(10);
            this.customTextBox3.PasswordChar = true;
            this.customTextBox3.PlaceholderText = "this is a place holder";
            this.customTextBox3.Radius = 40;
            this.customTextBox3.Size = new System.Drawing.Size(430, 130);
            this.customTextBox3.TabIndex = 3;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox4.Location = new System.Drawing.Point(336, 251);
            this.customTextBox4.Multiline = false;
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Padding = new System.Windows.Forms.Padding(10);
            this.customTextBox4.PasswordChar = false;
            this.customTextBox4.PlaceholderText = "this is a place holder";
            this.customTextBox4.Radius = 20;
            this.customTextBox4.Size = new System.Drawing.Size(430, 41);
            this.customTextBox4.TabIndex = 4;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(305, 350);
            this.customButton1.Name = "customButton1";
            this.customButton1.Radius = 40;
            this.customButton1.Size = new System.Drawing.Size(158, 48);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "get text";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private customs.customTextBox customTextBox1;
        private customs.customTextBox customTextBox2;
        private customs.customTextBox customTextBox3;
        private customs.customTextBox customTextBox4;
        private customs.CustomButton customButton1;
    }
}