namespace DbBackupManager.Core
{
    public class DbBackup
    {
        public string Timestamp { get; set; }
        public string Note { get; set; }
        public string[] Databases { get; set; }
    }
}