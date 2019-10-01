using System;
using System.Linq;
using DbBackupManager.Core;

namespace DbBackupManager.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            var bs = new BackupService(@"Data Source=.\SQLEXPRESS;Initial Catalog=SafetyDesign_Dev;Integrated Security=True", @"D:\_TEMP\DbBackupManager");
            var dbs = bs.GetAllUserDatabases().ToList();
            dbs.ForEach(db => System.Console.WriteLine(db));

            var br = new BackupRepository(@"d:\_TEMP\DbBackupManager\_backups.json");
            var backups = br.GetAll();
        }
    }
}
