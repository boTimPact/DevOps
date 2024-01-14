using System;

namespace DevOps.Data;

public class TimestampService : ITimestampService
{
    private readonly ITimestampData _timespans;

    public TimestampService(ITimestampData timespans)
    {
        _timespans = timespans;
    }

    public List<string> GetAll()
    {
        return _timespans.Timespans;
    }

    public void SaveTimestamp(string timestamp)
    {
        _timespans.Timespans.Add(timestamp);
    }
}

