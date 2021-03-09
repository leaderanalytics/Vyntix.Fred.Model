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
    [XmlType("vintage_date")]
    public class Vintage : IVintage
    {
        [JsonIgnore]
        [XmlIgnore]
        public int ID { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public string Symbol { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public DateTime VintageDate { get; set; }

        [XmlText]
        [JsonIgnore]
        public string VintageDateString
        {
            get => VintageDate.ToString("d");
            set => VintageDate = Convert.ToDateTime(value);
        }

        [JsonIgnore]
        [XmlIgnore]
        public ICollection<IObservation> Observations { get; set; }

        public Vintage() => Observations = new List<IObservation>();
    }
}
