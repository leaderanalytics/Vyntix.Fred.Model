namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredCategoryTag
{
    string CategoryID { get; set; }
    DateTime CreatedDate { get; set; }
    string GroupID { get; set; }
    string Name { get; set; }
    string NativeID { get; }
    string Notes { get; set; }
    int Popularity { get; set; }
}
