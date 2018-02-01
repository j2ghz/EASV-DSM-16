using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite
{
    class Start
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Time { get; set; }
    }
}
