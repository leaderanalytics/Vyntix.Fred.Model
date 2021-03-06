using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
    [XmlType("series")]
    public partial class Series : ISeries
    {
        [JsonIgnore]
        [XmlIgnore]
        public int ID { get; set; }

        [JsonIgnore]
        [XmlIgnore]
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
    }
}
