namespace FolderReport
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            generateFolderReportButton = new Button();
            label1 = new Label();
            selectFolderButton = new Button();
            selectOutputButton = new Button();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            resetButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            progressLabel = new ToolStripStatusLabel();
            timer2 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // generateFolderReportButton
            // 
            generateFolderReportButton.BackColor = Color.FromArgb(64, 64, 64);
            generateFolderReportButton.FlatStyle = FlatStyle.Flat;
            generateFolderReportButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            generateFolderReportButton.ForeColor = SystemColors.Control;
            generateFolderReportButton.Location = new Point(112, 146);
            generateFolderReportButton.Name = "generateFolderReportButton";
            generateFolderReportButton.Size = new Size(407, 38);
            generateFolderReportButton.TabIndex = 0;
            generateFolderReportButton.Text = "Generate Report";
            generateFolderReportButton.UseVisualStyleBackColor = false;
            generateFolderReportButton.Click += generateFolderReportButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 1;
            label1.Text = "Step 1";
            // 
            // selectFolderButton
            // 
            selectFolderButton.BackColor = Color.FromArgb(64, 64, 64);
            selectFolderButton.FlatStyle = FlatStyle.Flat;
            selectFolderButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectFolderButton.ForeColor = SystemColors.Control;
            selectFolderButton.Location = new Point(112, 30);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(407, 38);
            selectFolderButton.TabIndex = 2;
            selectFolderButton.Text = "Select folder";
            selectFolderButton.UseVisualStyleBackColor = false;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // selectOutputButton
            // 
            selectOutputButton.BackColor = Color.FromArgb(64, 64, 64);
            selectOutputButton.FlatStyle = FlatStyle.Flat;
            selectOutputButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectOutputButton.ForeColor = SystemColors.Control;
            selectOutputButton.Location = new Point(112, 88);
            selectOutputButton.Name = "selectOutputButton";
            selectOutputButton.Size = new Size(407, 38);
            selectOutputButton.TabIndex = 3;
            selectOutputButton.Text = "Select report output";
            selectOutputButton.UseVisualStyleBackColor = false;
            selectOutputButton.Click += selectOutputButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 4;
            label2.Text = "Step 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 5;
            label3.Text = "Step 3";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(64, 64, 64);
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = SystemColors.Control;
            resetButton.Location = new Point(112, 206);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(407, 38);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, progressLabel });
            statusStrip1.Location = new Point(0, 277);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(556, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Enabled = false;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // progressLabel
            // 
            progressLabel.BackColor = SystemColors.ButtonFace;
            progressLabel.ForeColor = Color.Black;
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(190, 17);
            progressLabel.Text = "Version 0.1.0.4 - Builddate 230511.1";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(556, 299);
            Controls.Add(statusStrip1);
            Controls.Add(resetButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selectOutputButton);
            Controls.Add(selectFolderButton);
            Controls.Add(label1);
            Controls.Add(generateFolderReportButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "FolderReport";
            Load += MainWindow_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateFolderReportButton;
        private Label label1;
        private Button selectFolderButton;
        private Button selectOutputButton;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Button resetButton;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel progressLabel;
        private System.Windows.Forms.Timer timer2;
    }
}