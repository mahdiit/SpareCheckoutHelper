using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using System.Text;

namespace SpareCheckoutHelper.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if(selectFolder.ShowDialog() == DialogResult.OK)
            {
                txtLocalFolder.Text = selectFolder.SelectedPath;
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {            
            jobProgress.MarqueeAnimationSpeed = 30;
            Application.DoEvents();
            btnExec.Enabled = false;
            btnSelectFolder.Enabled = false;
            txtGitUrl.Enabled = false;
            txtGitFolder.Enabled = false;

            txtLog.Text = "";

            var cmd = new StringBuilder();
            cmd.AppendLine("@echo off");
            cmd.AppendLine("git init");
            cmd.AppendLine("git config core.sparsecheckout true");
            cmd.AppendLine("git sparse-checkout init --cone");
            cmd.AppendLine("git sparse-checkout add " + txtGitFolder.Text);
            cmd.AppendLine("git remote add -f origin " + txtGitUrl.Text);
            cmd.AppendLine("git pull origin master");

            var filePath = AppDomain.CurrentDomain.BaseDirectory + "\\run.bat";
            File.WriteAllText(filePath, cmd.ToString());

            var p = Process.Start(new ProcessStartInfo()
            {
                WorkingDirectory = txtLocalFolder.Text,
                FileName = filePath,
                UseShellExecute = false,
                RedirectStandardOutput = true
            });

            if (p == null)
                return;

            jobProgress.MarqueeAnimationSpeed = 0;
            btnExec.Enabled = true;
            btnSelectFolder.Enabled = true;
            txtGitUrl.Enabled = true;
            txtGitFolder.Enabled = true;
        }
    }
}