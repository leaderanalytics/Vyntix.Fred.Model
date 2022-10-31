namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("category")]
public class RelatedCategory : IRelatedCategory
{
    [JsonIgnore]
    [XmlIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    [MaxLength(100)]
    [Required]
    public string CategoryID { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(NumberToStringConverter))]
    [XmlAttribute("id")]
    [MaxLength(100)]
    [Required]
    public string RelatedCategoryID { get; set; }
}
