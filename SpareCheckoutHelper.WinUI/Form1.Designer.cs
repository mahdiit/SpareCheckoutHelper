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
            this.btnExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(309, 34);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 1;
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
            this.txtLocalFolder.TabIndex = 0;
            // 
            // txtGitUrl
            // 
            this.txtGitUrl.Location = new System.Drawing.Point(12, 88);
            this.txtGitUrl.Name = "txtGitUrl";
            this.txtGitUrl.Size = new System.Drawing.Size(372, 23);
            this.txtGitUrl.TabIndex = 2;
            // 
            // txtGitFolder
            // 
            this.txtGitFolder.Location = new System.Drawing.Point(12, 144);
            this.txtGitFolder.Name = "txtGitFolder";
            this.txtGitFolder.Size = new System.Drawing.Size(372, 23);
            this.txtGitFolder.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGitFolder);
            this.Controls.Add(this.txtGitUrl);
            this.Controls.Add(this.txtLocalFolder);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnSelectFolder);
            this.MaximizeBox = false;
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
        private Button btnExec;
        private Label label1;
        private Label label2;
        private Label label3;
        private FolderBrowserDialog selectFolder;
    }
}