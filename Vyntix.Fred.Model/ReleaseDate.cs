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
    [XmlType("release_date")]
    public class ReleaseDate : IReleaseDate
    {
        [JsonIgnore]
        [XmlIgnore]
        public int ID { get; set; }

        [JsonPropertyName("release_id")]
        [JsonConverter(typeof(JSONNumberConverter))]
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
}
