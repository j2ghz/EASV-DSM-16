using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite.UWP
{
    class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.RoamingFolder.Path, filename);
        }
    }
}
