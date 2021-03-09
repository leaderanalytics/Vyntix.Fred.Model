using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
    // There is no Fred API that directly populates this entity.
    // This entity is intended to join multiple categories with multiple series.

    public class SeriesCategory : ISeriesCategory
    {
        public int ID { get; set; }
     
        [MaxLength(100)]
        [Required]
        public string CategoryID { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string Symbol { get; set; }
    }
}
