namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredCategory
{
    List<FredCategoryTag> CategoryTags { get; set; }
    List<FredCategory> Children { get; set; }
    string Name { get; set; }
    string NativeID { get; set; }
    string ParentID { get; set; }
    List<FredCategory> Related { get; set; }
    List<FredSeries> Series { get; set; }
}
