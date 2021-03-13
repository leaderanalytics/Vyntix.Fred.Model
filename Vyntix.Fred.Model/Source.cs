using LeaderAnalytics.Core.Serialization.Json;
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
    [XmlType("source")]
    public class Source : ISource
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

        [JsonPropertyName("link")]
        [XmlAttribute("link")]
        [MaxLength(400)]
        public string Link { get; set; }

        [JsonPropertyName("notes")]
        [XmlAttribute("notes")]
        public string Notes { get; set; }
    }
}
