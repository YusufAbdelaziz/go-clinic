namespace goclinic.customs
{
    partial class customCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customCard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.patientDetailCardTopPanel = new System.Windows.Forms.Panel();
            this.patientNumber = new System.Windows.Forms.Label();
            this.showMoreButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientName = new System.Windows.Forms.Label();
            this.eyeImage = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.patientDetailCardTopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.patientDetailCardTopPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showMoreButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.06142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.23561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 248);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // patientDetailCardTopPanel
            // 
            this.patientDetailCardTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.patientDetailCardTopPanel.Controls.Add(this.patientNumber);
            this.patientDetailCardTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientDetailCardTopPanel.Location = new System.Drawing.Point(3, 76);
            this.patientDetailCardTopPanel.Name = "patientDetailCardTopPanel";
            this.patientDetailCardTopPanel.Size = new System.Drawing.Size(304, 68);
            this.patientDetailCardTopPanel.TabIndex = 0;
            // 
            // patientNumber
            // 
            this.patientNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientNumber.Location = new System.Drawing.Point(0, 0);
            this.patientNumber.Name = "patientNumber";
            this.patientNumber.Size = new System.Drawing.Size(304, 68);
            this.patientNumber.TabIndex = 2;
            this.patientNumber.Text = "01097363250";
            this.patientNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.showMoreButton.Location = new System.Drawing.Point(3, 150);
            this.showMoreButton.Name = "showMoreButton";
            this.showMoreButton.Size = new System.Drawing.Size(304, 95);
            this.showMoreButton.TabIndex = 1;
            this.showMoreButton.Text = "عرض المزيد";
            this.showMoreButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showMoreButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.patientName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 67);
            this.panel1.TabIndex = 2;
            // 
            // patientName
            // 
            this.patientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientName.Location = new System.Drawing.Point(0, 0);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(304, 67);
            this.patientName.TabIndex = 0;
            this.patientName.Text = "رنا محى الدين ربيع احمد";
            this.patientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eyeImage
            // 
            this.eyeImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.eyeImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eyeImage.ImageStream")));
            this.eyeImage.TransparentColor = System.Drawing.Color.Transparent;
            this.eyeImage.Images.SetKeyName(0, "eye.png");
            // 
            // customCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(310, 248);
            this.MinimumSize = new System.Drawing.Size(310, 248);
            this.Name = "customCard";
            this.Size = new System.Drawing.Size(310, 248);
            this.Click += new System.EventHandler(this.customCard_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.patientDetailCardTopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel patientDetailCardTopPanel;
        public Button showMoreButton;
        private ImageList eyeImage;
        private Label patientNumber;
        private Panel panel1;
        private Label patientName;
    }
}
