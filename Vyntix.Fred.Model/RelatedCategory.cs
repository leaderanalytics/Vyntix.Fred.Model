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
}
