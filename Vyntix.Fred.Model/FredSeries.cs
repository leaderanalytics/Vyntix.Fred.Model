namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("series")]
public partial class FredSeries : IFredSeries
{
    [JsonIgnore]
    [XmlIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    [MaxLength(50)]
    public string ReleaseID { get; set; }

    [JsonPropertyName("id")]
    [XmlAttribute("id")]
    [MaxLength(50)]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("title")]
    [XmlAttribute("title")]
    [MaxLength(400)]
    [Required]
    public string Title { get; set; }

    [JsonPropertyName("frequency")]
    [XmlAttribute("frequency")]
    [MaxLength(50)]
    public string Frequency { get; set; }

    [JsonPropertyName("units")]
    [XmlAttribute("units")]
    [MaxLength(100)]
    public string Units { get; set; }

    [JsonPropertyName("seasonal_adjustment_short")]
    [XmlAttribute("seasonal_adjustment_short")]
    [MaxLength(50)]
    public string SeasonalAdj { get; set; }


    /// <summary>
    /// Date and time in FRED system when series was last updated.
    /// </summary>
    [JsonPropertyName("last_updated")]
    [XmlAttribute("last_updated")]
    [MaxLength(50)]
    public String LastUpdated { get; set; }  

    [JsonPropertyName("popularity")]
    [XmlAttribute("popularity")]
    public int Popularity { get; set; }

    [JsonPropertyName("realtime_start")]
    [XmlAttribute("realtime_start")]
    public DateTime RTStart { get; set; }

    [JsonPropertyName("notes")]
    [XmlAttribute("notes")]
    public string Notes { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public bool? HasVintages { get; set; }

    /// <summary>
    /// Date and time FRED was last queried for new vintages or observations.
    /// </summary>
    [JsonIgnore]
    [XmlIgnore]
    public DateTime LastObsCheck { get; set; }
   
    /// <summary>
    /// Date and time FRED was last queried for updates to series metadata.
    /// </summary>
    [JsonIgnore]
    [XmlIgnore]
    public DateTime LastMetadataCheck { get; set; }
}
