using LeaderAnalytics.Core.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
 
    [XmlType("category")]
    public class Category : ICategory
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
        public List<Series> Series { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<Category> Children { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<Category> Related { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<CategoryTag> CategoryTags { get; set; }


        public Category()
        {
            Children = new List<Category>();
            Related = new List<Category>();
            Series = new List<Series>();
            CategoryTags = new List<CategoryTag>();
        }
    }
}
