namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("observation")]
public class FredObservation : IFredObservation
{
    [XmlIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    [MaxLength(50)]
    [Required]
    public string Symbol { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime VintageDate { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime ObsDate { get; set; }

    [JsonPropertyName("value")]
    [XmlAttribute("value")]
    [MaxLength(50)]
    public string Value { get; set; }

    [JsonPropertyName("realtime_start")]
    [XmlAttribute("realtime_start")]
    public string VintageDateString
    {
        get => VintageDate.ToString();
        set => VintageDate = Convert.ToDateTime(value);
    }

    [JsonPropertyName("date")]
    [XmlAttribute("date")]
    public string ObsDateString
    {
        get => ObsDate.ToString("d");
        set => ObsDate = Convert.ToDateTime(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public IFredVintage Vintage { get; set; }


    [JsonIgnore]
    [XmlIgnore]
    public bool? HasVintages { get; set; }

}
