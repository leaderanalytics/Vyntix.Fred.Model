namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredSource
{
    string Link { get; set; }
    string Name { get; set; }
    string NativeID { get; set; }
    string Notes { get; set; }
    IEnumerable<FredSourceRelease> SourceReleases { get; set; }
}
