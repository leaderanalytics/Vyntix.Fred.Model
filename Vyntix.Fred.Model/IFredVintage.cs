namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredVintage
{
    string Symbol { get; set; }
    DateTime VintageDate { get; set; }
    ICollection<IFredObservation> Observations { get; set; }
}
