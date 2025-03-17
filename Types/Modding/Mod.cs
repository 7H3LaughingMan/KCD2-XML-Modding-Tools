using System.Xml.Serialization;

namespace KCD2.Types.Modding;

[XmlType("kcd_mod")]
public class Mod
{
    [XmlElement("info")]
    public ModInfo Info { get; set; } = new ModInfo();

    public static Mod Load(string filePath)
    {
        var serializer = new XmlSerializer(typeof(Mod));
        using var fileStream = File.OpenRead(filePath);

        return (Mod)serializer.Deserialize(fileStream);
    }
}