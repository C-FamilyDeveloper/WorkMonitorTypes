namespace WorkMonitorTypes.Requests
{
    public class WorkerInfo
    {
        public string Worker { get; set; }
        public DateTime EventDateTime { get; set; }
        public TimeSpan WorkTime { get; set; }
        public TimeSpan IdleTime { get; set; }
        public string Application { get; set; }
        public string? Site { get; set; }
    }
}
