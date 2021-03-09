using System;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
    public interface IReleaseDate
    {
        DateTime DateReleased { get; set; }
        string ReleaseID { get; set; }
    }
}