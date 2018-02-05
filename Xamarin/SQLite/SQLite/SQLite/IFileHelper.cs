using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
