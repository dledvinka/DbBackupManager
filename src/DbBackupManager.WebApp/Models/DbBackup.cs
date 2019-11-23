using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbBackupManager.WebApp.Models
{
    public class DbBackup
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public string Databases { get; set; }
    }
}
