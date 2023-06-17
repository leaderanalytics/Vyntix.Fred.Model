namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("category")]
public class FredCategory : IFredCategory
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

    [JsonPropertyName("parent_id")]
    [JsonConverter(typeof(NumberToStringConverter))]
    [XmlAttribute("parent_id")]
    [MaxLength(100)]
    public string ParentID { get; set; }

    [JsonPropertyName("name")]
    [XmlAttribute("name")]
    [MaxLength(400)]
    [Required]
    public string Name { get; set; }

    [JsonPropertyName("seriess")]
    [XmlElement("seriess", IsNullable = true)]
    public List<FredSeries> Series { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public List<FredCategory> Children { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public List<FredCategory> Related { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public List<CategoryTag> CategoryTags { get; set; }


    public FredCategory()
    {
        Children = new List<FredCategory>();
        Related = new List<FredCategory>();
        Series = new List<FredSeries>();
        CategoryTags = new List<CategoryTag>();
    }
}
