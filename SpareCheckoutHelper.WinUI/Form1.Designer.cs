namespace SpareCheckoutHelper.WinUI
{
    partial class Form1
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtLocalFolder = new System.Windows.Forms.TextBox();
            this.txtGitUrl = new System.Windows.Forms.TextBox();
            this.txtGitFolder = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.jobProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(309, 34);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtLocalFolder
            // 
            this.txtLocalFolder.Location = new System.Drawing.Point(12, 34);
            this.txtLocalFolder.Name = "txtLocalFolder";
            this.txtLocalFolder.ReadOnly = true;
            this.txtLocalFolder.Size = new System.Drawing.Size(291, 23);
            this.txtLocalFolder.TabIndex = 1;
            // 
            // txtGitUrl
            // 
            this.txtGitUrl.Location = new System.Drawing.Point(12, 88);
            this.txtGitUrl.Name = "txtGitUrl";
            this.txtGitUrl.Size = new System.Drawing.Size(372, 23);
            this.txtGitUrl.TabIndex = 1;
            // 
            // txtGitFolder
            // 
            this.txtGitFolder.Location = new System.Drawing.Point(12, 144);
            this.txtGitFolder.Name = "txtGitFolder";
            this.txtGitFolder.Size = new System.Drawing.Size(372, 23);
            this.txtGitFolder.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.Location = new System.Drawing.Point(12, 256);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(372, 182);
            this.txtLog.TabIndex = 2;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(12, 173);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(372, 23);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Git";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Git folder to download";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(12, 238);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(111, 15);
            this.lblCommand.TabIndex = 3;
            this.lblCommand.Text = "Command Window";
            // 
            // jobProgress
            // 
            this.jobProgress.Location = new System.Drawing.Point(12, 202);
            this.jobProgress.Name = "jobProgress";
            this.jobProgress.Size = new System.Drawing.Size(372, 23);
            this.jobProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.jobProgress.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.jobProgress);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtGitFolder);
            this.Controls.Add(this.txtGitUrl);
            this.Controls.Add(this.txtLocalFolder);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "Form1";
            this.Text = "Spare Checkout Git";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelectFolder;
        private TextBox txtLocalFolder;
        private TextBox txtGitUrl;
        private TextBox txtGitFolder;
        private TextBox txtLog;
        private Button btnExec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCommand;
        private FolderBrowserDialog selectFolder;
        private ProgressBar jobProgress;
    }
}