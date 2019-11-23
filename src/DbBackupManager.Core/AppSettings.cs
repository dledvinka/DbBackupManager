using System;
using System.Collections.Generic;
using System.Text;

namespace DbBackupManager.Core
{
    public class AppSettings
    {
        public string StringSetting { get; set; }

        public int IntegerSetting { get; set; }

        public bool BooleanSetting { get; set; }
        public string ConnectionString { get; set; }
        public string BackupFolderPath { get; set; }
    }
}
