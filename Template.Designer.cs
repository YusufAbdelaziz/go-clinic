namespace goclinic
{
    partial class Template
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.sidebarLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.stethoscopeIconPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sidebarLayoutPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarLayoutPanel
            // 
            this.sidebarLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.sidebarLayoutPanel.Controls.Add(this.logoutButton);
            this.sidebarLayoutPanel.Controls.Add(this.helpButton);
            this.sidebarLayoutPanel.Controls.Add(this.settingsButton);
            this.sidebarLayoutPanel.Controls.Add(this.namePanel);
            this.sidebarLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebarLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.sidebarLayoutPanel.Location = new System.Drawing.Point(1269, 0);
            this.sidebarLayoutPanel.Name = "sidebarLayoutPanel";
            this.sidebarLayoutPanel.Size = new System.Drawing.Size(112, 944);
            this.sidebarLayoutPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(0, 811);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(122, 123);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "تسجيل الخروج";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.Location = new System.Drawing.Point(0, 695);
            this.helpButton.Margin = new System.Windows.Forms.Padding(0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(122, 116);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "المساعدة";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(0, 575);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(119, 117);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "الإعدادات";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(25)))));
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 493);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(112, 79);
            this.namePanel.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(36, 17);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 45);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "M";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.topBarPanel.Controls.Add(this.stethoscopeIconPanel);
            this.topBarPanel.Controls.Add(this.userNameLabel);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(1269, 79);
            this.topBarPanel.TabIndex = 1;
            // 
            // stethoscopeIconPanel
            // 
            this.stethoscopeIconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.stethoscopeIconPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stethoscopeIconPanel.BackgroundImage")));
            this.stethoscopeIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stethoscopeIconPanel.Location = new System.Drawing.Point(0, 0);
            this.stethoscopeIconPanel.Name = "stethoscopeIconPanel";
            this.stethoscopeIconPanel.Size = new System.Drawing.Size(104, 79);
            this.stethoscopeIconPanel.TabIndex = 2;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.Location = new System.Drawing.Point(467, 21);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(241, 30);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Dr. Mostaffa Mohamed";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1381, 944);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.sidebarLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Template";
            this.Text = "GoClinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebarLayoutPanel.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebarLayoutPanel;
        private Button logoutButton;
        private Button helpButton;
        private Button settingsButton;
        private Panel topBarPanel;
        private Label userNameLabel;
        private ImageList imageList1;
        private Panel stethoscopeIconPanel;
        private Label nameLabel;
        private Panel namePanel;
    }
}