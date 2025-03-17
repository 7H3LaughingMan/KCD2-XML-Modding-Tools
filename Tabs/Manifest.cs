namespace KCD2.Tabs;

public partial class Manifest : UserControl
{
    private static Types.Modding.Mod _mod;

    public Manifest(Types.Modding.Mod mod)
    {
        _mod = mod;

        InitializeComponent();
    }

    private void Manifest_Load(object sender, EventArgs e)
    {
        dateTimePickerCreatedOn.Format = DateTimePickerFormat.Custom;
        dateTimePickerCreatedOn.CustomFormat = "yyyy-MM-dd";


        textBoxName.DataBindings.Add("Text", _mod.Info, "Name");
        textBoxModId.DataBindings.Add("Text", _mod.Info, "ModId");
        textBoxDescription.DataBindings.Add("Text", _mod.Info, "Description");
        textBoxAuthor.DataBindings.Add("Text", _mod.Info, "Author");
        textBoxVersion.DataBindings.Add("Text", _mod.Info, "Version");
        dateTimePickerCreatedOn.DataBindings.Add("Value", _mod.Info, "CreatedOn");
        checkBoxModifiesLevel.DataBindings.Add("Checked", _mod.Info, "ModifiesLevel");
    }
}
