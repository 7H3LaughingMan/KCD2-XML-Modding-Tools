using System.Diagnostics;
using System.Text.Json;

namespace KCD2.Tools
{
    public class Settings
    {
        public string InstallPath { get; set; } = string.Empty;

        public static bool CheckInstall(string installPath)
        {
            if (string.IsNullOrEmpty(installPath)) return false;

            if (!Path.IsPathFullyQualified(installPath)) return false;

            if (!Directory.Exists(installPath)) return false;

            if (!Directory.Exists(Path.Combine(installPath, "Bin"))) return false;

            string[] files = Directory.GetFiles(Path.Combine(installPath, "Bin"), "KingdomCome.exe", SearchOption.AllDirectories);
            if (files.Length != 1) return false;

            var fileVersionInfo = FileVersionInfo.GetVersionInfo(files[0]);
            if (!string.Equals(fileVersionInfo.FileDescription, "Kingdom Come: Deliverance II")) return false;

            if (!File.Exists(Path.Combine(installPath, "Data", "Tables.pak"))) return false;

            return true;
        }

        public static Settings Load()
        {
            var applicationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KCD2 XML Modding Tools");

            if (!Directory.Exists(applicationFolder))
                Directory.CreateDirectory(applicationFolder);

            var settingsFile = Path.Combine(applicationFolder, "settings.json");

            if (!File.Exists(settingsFile))
                return new();

            var settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(settingsFile));

            return settings ?? new();
        }

        public static void Save(Settings value)
        {
            var applicationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KCD2 XML Modding Tools");

            if (!Directory.Exists(applicationFolder))
                Directory.CreateDirectory(applicationFolder);

            var settingsFile = Path.Combine(applicationFolder, "settings.json");

            File.WriteAllText(settingsFile, JsonSerializer.Serialize(value));
        }

        public static DialogResult PromptInstallPath()
        {
            using var folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select KCD2 Install Folder",
                ShowNewFolderButton = false,
                UseDescriptionForTitle = true
            };

            var dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if (!CheckInstall(folderBrowserDialog.SelectedPath))
                {
                    var messageResult = MessageBox.Show("Invalid KCD2 Install Folder!",
                        "KCD2 XML Modding Tools",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );

                    return messageResult;
                }

                Program.Settings.InstallPath = folderBrowserDialog.SelectedPath;
                Save(Program.Settings);
            }

            return dialogResult;
        }
    }
}