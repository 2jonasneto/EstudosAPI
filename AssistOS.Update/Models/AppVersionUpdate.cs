namespace AssistOS.Update.Models
{
    public class AppVersionUpdate
    {
        public Guid Id { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string LinkFile { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
    }
}
