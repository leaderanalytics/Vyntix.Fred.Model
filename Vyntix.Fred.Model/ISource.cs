namespace LeaderAnalytics.Vyntix.Fred.Model
{
    public interface ISource
    {
        string Link { get; set; }
        string Name { get; set; }
        string NativeID { get; set; }
        string Notes { get; set; }
    }
}