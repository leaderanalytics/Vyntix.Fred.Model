namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredSeries
{
    string Frequency { get; set; }
    string LastUpdated { get; set; }
    string Notes { get; set; }
    int Popularity { get; set; }
    string ReleaseID { get; set; }
    DateTime RTStart { get; set; }
    string SeasonalAdj { get; set; }
    string Symbol { get; set; }
    string Title { get; set; }
    string Units { get; set; }
}
