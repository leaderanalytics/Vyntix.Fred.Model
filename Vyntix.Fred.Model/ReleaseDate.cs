﻿namespace LeaderAnalytics.Vyntix.Fred.Model;

[XmlType("release_date")]
public class ReleaseDate : IReleaseDate
{
    [JsonIgnore]
    [XmlIgnore]
    public int ID { get; set; }

    [JsonPropertyName("release_id")]
    [JsonConverter(typeof(NumberToStringConverter))]
    [XmlAttribute("release_id")]
    public string ReleaseID { get; set; }

    [JsonIgnore]
    [XmlText]
    public string DateReleaseString
    {
        get => DateReleased.ToString("d");
        set => DateReleased = Convert.ToDateTime(value);
    }

    [JsonPropertyName("date")]
    [XmlIgnore]
    public DateTime DateReleased { get; set; }
}
