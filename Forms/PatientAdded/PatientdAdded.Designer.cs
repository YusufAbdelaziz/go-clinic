namespace goclinic
{
    partial class PatientdAdded
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientdAdded));
            this.successfully = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // successfully
            // 
            this.successfully.AutoSize = true;
            this.successfully.BackColor = System.Drawing.Color.Transparent;
            this.successfully.Font = new System.Drawing.Font("Cairo", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.successfully.ForeColor = System.Drawing.Color.White;
            this.successfully.Location = new System.Drawing.Point(26, 62);
            this.successfully.Name = "successfully";
            this.successfully.Size = new System.Drawing.Size(349, 60);
            this.successfully.TabIndex = 0;
            this.successfully.Text = "تم إضافة المريض بنجاح";
            this.successfully.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successfully.Click += new System.EventHandler(this.successfully_Click);
            // 
            // PatientdAdded
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(400, 184);
            this.ControlBox = false;
            this.Controls.Add(this.successfully);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientdAdded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label successfully;
    }
}