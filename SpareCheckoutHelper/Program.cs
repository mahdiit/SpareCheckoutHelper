using System.Diagnostics;
using System.Text;

namespace SpareCheckoutHelper
{
    internal class Program
    {
        static async Task Main(string[] args)
        {            
            string folderToCheckout = "";
            string gitRepoUrl = "";
            string localDir = "";

            Console.WriteLine("Enter local checkout folder(must empty):");
            localDir = Console.ReadLine();

            Console.WriteLine("Enter git url:");
            gitRepoUrl = Console.ReadLine();

            Console.WriteLine("forlder to checkout:");
            folderToCheckout = Console.ReadLine();

            var cmd = new StringBuilder();
            cmd.AppendLine("@echo off");
            cmd.AppendLine("git init");
            cmd.AppendLine("git config core.sparsecheckout true");
            cmd.AppendLine("git sparse-checkout init --cone");
            cmd.AppendLine("git sparse-checkout add " + folderToCheckout);
            cmd.AppendLine("git remote add -f origin " + gitRepoUrl);
            cmd.AppendLine("git pull origin master");

            var filePath = AppDomain.CurrentDomain.BaseDirectory + "\\run.bat";
            File.WriteAllText(filePath, cmd.ToString());

            Console.WriteLine("########### Start ###########");
            var p = Process.Start(new ProcessStartInfo()
            {
                WorkingDirectory = localDir,
                FileName = filePath
            });

            if (p == null)
                return;

            await p.WaitForExitAsync();
            Console.WriteLine("########### End ###########");
            Console.ReadKey();
        }
    }
}