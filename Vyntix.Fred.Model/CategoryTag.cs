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
    [XmlType("tag")]
    public class CategoryTag : ICategoryTag
    {
        [JsonIgnore]
        [XmlIgnore]
        public int ID { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        [MaxLength(100)]
        [Required]
        public string NativeID { get => Name + GroupID; }

        [JsonIgnore]
        [XmlIgnore]
        [MaxLength(100)]
        [Required]
        public string CategoryID { get; set; }

        [JsonPropertyName("name")]
        [XmlAttribute("name")]
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        [JsonPropertyName("group_id")]
        [XmlAttribute("group_id")]
        [MaxLength(100)]
        [Required]
        public string GroupID { get; set; }

        [JsonPropertyName("notes")]
        [XmlAttribute("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("created")]
        [XmlAttribute("created")]
        public String CreatedDateString
        {
            get => CreatedDate.ToString("d");
            set => CreatedDate = Convert.ToDateTime(value);
        }

        [JsonIgnore]
        [XmlIgnore]
        public DateTime CreatedDate { get; set; }

        [JsonPropertyName("popularity")]
        [XmlAttribute("popularity")]
        public int Popularity { get; set; }
    }
}
