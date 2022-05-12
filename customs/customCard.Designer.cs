namespace goclinic.customs
{
    partial class CustomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCard));
            this.patientCardTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.patientDetailCardTopPanel = new System.Windows.Forms.Panel();
            this.patientNumberPanel = new System.Windows.Forms.Label();
            this.showMoreButton = new System.Windows.Forms.Button();
            this.eyeImage = new System.Windows.Forms.ImageList(this.components);
            this.patientNamePanel = new System.Windows.Forms.Panel();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientCardTableLayout.SuspendLayout();
            this.patientDetailCardTopPanel.SuspendLayout();
            this.patientNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientCardTableLayout
            // 
            this.patientCardTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.patientCardTableLayout.ColumnCount = 1;
            this.patientCardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.patientCardTableLayout.Controls.Add(this.patientDetailCardTopPanel, 0, 1);
            this.patientCardTableLayout.Controls.Add(this.showMoreButton, 0, 2);
            this.patientCardTableLayout.Controls.Add(this.patientNamePanel, 0, 0);
            this.patientCardTableLayout.Location = new System.Drawing.Point(0, 0);
            this.patientCardTableLayout.Name = "patientCardTableLayout";
            this.patientCardTableLayout.RowCount = 3;
            this.patientCardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.patientCardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.06142F));
            this.patientCardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.23561F));
            this.patientCardTableLayout.Size = new System.Drawing.Size(310, 248);
            this.patientCardTableLayout.TabIndex = 0;
            // 
            // patientDetailCardTopPanel
            // 
            this.patientDetailCardTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.patientDetailCardTopPanel.Controls.Add(this.patientNumberPanel);
            this.patientDetailCardTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientDetailCardTopPanel.Location = new System.Drawing.Point(3, 76);
            this.patientDetailCardTopPanel.Name = "patientDetailCardTopPanel";
            this.patientDetailCardTopPanel.Size = new System.Drawing.Size(304, 68);
            this.patientDetailCardTopPanel.TabIndex = 0;
            // 
            // patientNumberPanel
            // 
            this.patientNumberPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientNumberPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientNumberPanel.Location = new System.Drawing.Point(0, 0);
            this.patientNumberPanel.Name = "patientNumberPanel";
            this.patientNumberPanel.Size = new System.Drawing.Size(304, 68);
            this.patientNumberPanel.TabIndex = 2;
            this.patientNumberPanel.Text = "01097363250";
            this.patientNumberPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showMoreButton
            // 
            this.showMoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(25)))));
            this.showMoreButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMoreButton.FlatAppearance.BorderSize = 0;
            this.showMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMoreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showMoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showMoreButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showMoreButton.ImageIndex = 0;
            this.showMoreButton.ImageList = this.eyeImage;
            this.showMoreButton.Location = new System.Drawing.Point(3, 150);
            this.showMoreButton.Name = "showMoreButton";
            this.showMoreButton.Size = new System.Drawing.Size(304, 95);
            this.showMoreButton.TabIndex = 1;
            this.showMoreButton.Text = "عرض المزيد";
            this.showMoreButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showMoreButton.UseVisualStyleBackColor = false;
            // 
            // eyeImage
            // 
            this.eyeImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.eyeImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eyeImage.ImageStream")));
            this.eyeImage.TransparentColor = System.Drawing.Color.Transparent;
            this.eyeImage.Images.SetKeyName(0, "eye.png");
            // 
            // patientNamePanel
            // 
            this.patientNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.patientNamePanel.Controls.Add(this.patientNameLabel);
            this.patientNamePanel.Location = new System.Drawing.Point(3, 3);
            this.patientNamePanel.Name = "patientNamePanel";
            this.patientNamePanel.Size = new System.Drawing.Size(304, 67);
            this.patientNamePanel.TabIndex = 2;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientNameLabel.Location = new System.Drawing.Point(0, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(304, 67);
            this.patientNameLabel.TabIndex = 0;
            this.patientNameLabel.Text = "رنا محى الدين ربيع احمد";
            this.patientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientNameLabel.Click += new System.EventHandler(this.patientName_Click);
            // 
            // CustomCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.patientCardTableLayout);
            this.MaximumSize = new System.Drawing.Size(310, 248);
            this.MinimumSize = new System.Drawing.Size(310, 248);
            this.Name = "CustomCard";
            this.Size = new System.Drawing.Size(310, 248);
            this.Click += new System.EventHandler(this.customCard_Click);
            this.patientCardTableLayout.ResumeLayout(false);
            this.patientDetailCardTopPanel.ResumeLayout(false);
            this.patientNamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel patientCardTableLayout;
        private Panel patientDetailCardTopPanel;
        public Button showMoreButton;
        private ImageList eyeImage;
        private Label patientNumberPanel;
        private Panel patientNamePanel;
        private Label patientNameLabel;
    }
}
