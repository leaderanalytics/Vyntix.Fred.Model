namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredSeriesTag
{
    DateTime CreatedDate { get; set; }
    string GroupID { get; set; }
    string Name { get; set; }
    string NativeID { get; }
    string Notes { get; set; }
    int Popularity { get; set; }
    string Symbol { get; set; }
}
