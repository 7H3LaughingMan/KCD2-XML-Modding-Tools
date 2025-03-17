using System.Xml.Serialization;

namespace KCD2.Types.Modding;

[XmlType("info")]
public class ModInfo
{
    [XmlElement("name")]
    public string Name { get; set; } = string.Empty;

    [XmlElement("modid")]
    public string ModId { get; set; } = string.Empty;

    [XmlElement("description")]
    public string Description { get; set; } = string.Empty;

    [XmlElement("author")]
    public string Author { get; set; } = string.Empty;

    [XmlElement("version")]
    public string Version { get; set; }

    [XmlIgnore]
    public DateTime CreatedOn { get; set; } = DateTime.Now;

    [XmlElement("created_on", DataType = "date")]
    internal string CreatedOnSurrogate
    {
        get => CreatedOn.ToString("yyyy-MM-dd");

        set
        {
            if(DateTime.TryParse(value, out var result))
                CreatedOn = result;
        }
    }

    [XmlElement("modifies_level")]
    public bool ModifiesLevel { get; set; }
}