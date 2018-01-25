using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinTest1
{
    public class Student : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
