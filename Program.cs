using LibGit2Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Initialize();
            StartPage startpage = new StartPage();
            IconHelper.SetFormIcon(startpage);
            EnableDoubleBuffering(startpage);

            //// Kullan�c� bilgileri ve GitHub eri�im token'�
            //string username = "YourGitHubUsername";
            //string email = "your.email@example.com";
            //string token = "YOUR_GITHUB_TOKEN";

            //// Uygulaman�n �al��t��� dizinden ba�layarak .git klas�r�n� bul
            //string repoPath = Repository.Discover(Directory.GetCurrentDirectory());
            //if (repoPath == null)
            //{
            //    Console.WriteLine("Hata: �al��t�r�lan dizin bir Git repository de�il.");
            //    return;
            //}

            //// Repository'nin ger�ek yolunu al
            //repoPath = Path.GetFullPath(Path.Combine(repoPath, ".."));

            //try
            //{
            //    var autoCommit = new AutoCommit(username, email, token);

            //    // Commit ve push i�lemini ba�lat�n
            //    autoCommit.CommitAndPushChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Bir hata olu�tu: {ex.Message}");
            //}

            Application.Run(startpage);
        }

        public static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        public static class IconHelper
        {
            private static Icon _appIcon;

            static IconHelper()
            {
                string iconFileName = "HTDS_Logo.png";

                if (File.Exists(iconFileName))
                {
                    using (Bitmap bitmap = new Bitmap(iconFileName))
                    {
                        IntPtr hIcon = bitmap.GetHicon();
                        _appIcon = Icon.FromHandle(hIcon);
                    }
                }
                else
                {
                    Console.WriteLine("Icon file not found.");
                }
            }

            public static void SetFormIcon(Form form)
            {
                if (_appIcon != null)
                {
                    form.Icon = _appIcon;
                }
            }
        }

        public static void EnableDoubleBuffering(Form form)
        {
            if (form == null)
                return;

            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() => EnableDoubleBuffering(form)));
                return;
            }

            var property = form.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            property.SetValue(form, true, null);
        }

        public static void EnableDoubleBuffering(Panel panel)
        {
            if (panel == null)
                return;

            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(() => EnableDoubleBuffering(panel)));
                return;
            }

            var property = panel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            property.SetValue(panel, true, null);
        }
    }
}