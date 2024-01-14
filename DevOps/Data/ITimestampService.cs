namespace DevOps.Data
{
    public interface ITimestampService
    {
        List<string> GetAll();
        void SaveTimestamp(string timespan);
    }
}