namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("source")]
public class FredSource : IFredSource
{
    [JsonIgnore]
    [XmlIgnore]
    public int ID { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(NumberToStringConverter))]
    [XmlAttribute("id")]
    [Required]
    [MaxLength(100)]
    public string NativeID { get; set; }

    [JsonPropertyName("name")]
    [XmlAttribute("name")]
    [MaxLength(400)]
    [Required]
    public string Name { get; set; }

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
