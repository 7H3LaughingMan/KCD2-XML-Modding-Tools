using KCD2.Tools;

namespace KCD2;

internal static class Program
{
    internal static Settings Settings { get; set; } = Settings.Load();

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        if (!Settings.CheckInstall(Settings.InstallPath))
        {
            while (true)
            {
                var dialogResult = Settings.PromptInstallPath();

                if (dialogResult == DialogResult.OK) break;
                if (dialogResult == DialogResult.Cancel) return;
            }
        }

        MessageBox.Show(ApplicationDeployment.CurrentVersion.ToString());
        Application.Run(new MainApplication());
    }
}