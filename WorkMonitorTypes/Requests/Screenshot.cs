namespace WorkMonitorTypes.Requests
{
    public class Screenshot
    {
        public byte[] Image { get; set; }
        public DateTime ScreenshotDateTime { get; set; }
        public string ClientName { get; set; }
    }
}
