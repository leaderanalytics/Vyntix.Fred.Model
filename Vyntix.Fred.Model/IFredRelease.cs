﻿namespace LeaderAnalytics.Vyntix.Fred.Model;

public interface IFredRelease
{
    bool IsPressRelease { get; set; }
    string Link { get; set; }
    string Name { get; set; }
    string NativeID { get; set; }
    string Notes { get; set; }
    DateTime RTStart { get; set; }
    IEnumerable<FredSourceRelease> SourceReleases { get; set; }
}
