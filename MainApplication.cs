using System.Diagnostics;

namespace KCD2;

public partial class MainApplication : Form
{
    public MainApplication()
    {
        InitializeComponent();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Mod Manifest|mod.manifest"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var filePath = openFileDialog.FileName;
            var mod = Types.Modding.Mod.Load(filePath);
            
            var tabPage = new TabPage("Manifest");
            tabPage.Controls.Add(new Tabs.Manifest(mod));
            tabControl.TabPages.Add(tabPage);
        }
    }
}