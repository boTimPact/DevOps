using System;
namespace DevOps.Data;

public class TimestampData : ITimestampData
{
    public List<string> Timespans { get; set; } = new();
}