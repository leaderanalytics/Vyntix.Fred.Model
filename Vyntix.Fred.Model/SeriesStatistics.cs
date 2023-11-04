namespace LeaderAnalytics.Vyntix.Fred.Model;

public class SeriesStatistics
{
    public int ObservationCount { get; set; }
    public int VintageCount { get; set; }
    public int NullValueCount { get; set; }
    public decimal? MinValue { get; set; }
    public decimal? MaxValue { get; set; }
    public DateTime? FirstVintageDate { get; set; }
    public DateTime? LastVintageDate { get; set; }
    public DateTime? FirstObservationDate { get; set; }
    public DateTime? LastObservationDate { get; set;}

}
