namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredObservation
{
    DateTime ObsDate { get; set; }
    string Symbol { get; set; }
    decimal? Value { get; set; }
    DateTime VintageDate { get; set; }
    IFredVintage Vintage { get; set; }
}
