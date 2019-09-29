using System;
using System.Collections.Generic;
using System.Text;

namespace DbBackupManager
{
    public interface ISampleService
    {
        string GetCurrentDate();
    }

    public class SampleService : ISampleService
    {
        public string GetCurrentDate() => DateTime.Now.ToLongDateString();
    }
}
