using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TicTacToe.Models
{
    public class Cell : INotifyPropertyChanged
    {
        public Player Player { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
