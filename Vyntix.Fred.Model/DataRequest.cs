using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
    public class DataRequest
    {
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Symbol { get; set; }

        public DateTime RequestDate { get; set; }
    }
}
