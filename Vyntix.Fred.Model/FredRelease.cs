namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("release")]
public class FredRelease : IFredRelease
{
    [JsonIgnore]
    [XmlIgnore]
    public int ID { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(NumberToStringConverter))]
    [XmlAttribute("id")]
    [MaxLength(100)]
    [Required]
    public string NativeID { get; set; }

    // This column exists so we can persist NativeID of the related Source.  This column is used when downloaded releases by SourceID.  We need this
    // column on the Fred_Staging table - when exporting a SourceRelease row will be created on Vyntix because Source/Release reationship is many-to-many.
    [JsonIgnore]
    [XmlIgnore]
    [MaxLength(100)]
    [Required]
    public string SourceNativeID { get; set; }

    [JsonPropertyName("name")]
    [XmlAttribute("name")]
    [MaxLength(400)]
    [Required]
    public string Name { get; set; }

    [JsonPropertyName("press_release")]
    [XmlAttribute("press_release")]
    public bool IsPressRelease { get; set; }

    [JsonPropertyName("realtime_start")]
    [XmlAttribute("realtime_start")]
    public DateTime RTStart { get; set; }

    [JsonPropertyName("link")]
    [XmlAttribute("link")]
    [MaxLength(400)]
    public string Link { get; set; }

    [JsonPropertyName("notes")]
    [XmlAttribute("notes")]
    public string Notes { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public IEnumerable<FredSourceRelease> SourceReleases { get; set; }
}
