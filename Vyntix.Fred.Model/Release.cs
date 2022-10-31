namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("release")]
public class Release : IRelease
{
    [JsonIgnore]
    [XmlIgnore]
    public int ID { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(NumberToStringConverter))]
    [XmlAttribute("id")]
    public string NativeID { get; set; }

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
    public IEnumerable<SourceRelease> SourceReleases { get; set; }
}
