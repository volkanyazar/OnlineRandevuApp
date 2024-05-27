using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSystemApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Task.Run(() => StartWebAPI());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public static async Task StartWebAPI()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string correctedPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
                string apiRelativePath = @"OnlineRandevuApp.API";
                string apiFullPath = Path.Combine(correctedPath, apiRelativePath);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"run --project {apiFullPath}",
                    UseShellExecute = true
                };

                using (Process webApiProcess = new Process { StartInfo = startInfo })
                {
                    webApiProcess.Start();
                    await webApiProcess.WaitForExitAsync();
                }

                Debug.WriteLine("Web API started successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while starting the Web API: {ex.Message}");
                MessageBox.Show($"An error occurred while starting the Web API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class ProcessExtensions
    {
        public static Task WaitForExitAsync(this Process process, int timeout = 0)
        {
            if (process == null)
                throw new ArgumentNullException(nameof(process));

            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);

            if (timeout > 0)
            {
                Task.Delay(timeout).ContinueWith(t => tcs.TrySetCanceled());
            }

            return tcs.Task;
        }
    }
}
