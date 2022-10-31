namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IVintage
{
    string Symbol { get; set; }
    DateTime VintageDate { get; set; }
    ICollection<IObservation> Observations { get; set; }
}
