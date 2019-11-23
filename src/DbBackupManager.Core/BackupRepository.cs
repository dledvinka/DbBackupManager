using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DbBackupManager.Core
{
    public class BackupRepository
    {
        private readonly string _repositoryPath;

        public BackupRepository(string repositoryPath)
        {
            _repositoryPath = repositoryPath;
        }

        public List<DbBackup> GetAll()
        {
            var test = new DbBackups()
            {
                Backups = new List<DbBackup>()
                {
                    new DbBackup() { Databases = new string[] { "DB1", "DB2"}, Note = "Note", Timestamp = "Time"}
                }
            };

            var ser = Newtonsoft.Json.JsonConvert.SerializeObject(test);
            var fileContent = File.ReadAllText(_repositoryPath);
            var dbBackups = Newtonsoft.Json.JsonConvert.DeserializeObject<DbBackups>(fileContent);
            return dbBackups.Backups;
        }
    }
}
