using System;

namespace LeaderAnalytics.Vyntix.Fred.Model
{
    public interface IObservation
    {
        DateTime ObsDate { get; set; }
        string Symbol { get; set; }
        string Value { get; set; }
        DateTime VintageDate { get; set; }
        IVintage Vintage { get; set; }
    }
}