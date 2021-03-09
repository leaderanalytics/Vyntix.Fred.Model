using System.Collections.Generic;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
    public interface ICategory
    {
        List<CategoryTag> CategoryTags { get; set; }
        List<Category> Children { get; set; }
        string Name { get; set; }
        string NativeID { get; set; }
        string ParentID { get; set; }
        List<Category> Related { get; set; }
        List<Series> Series { get; set; }
    }
}