using System;
using System.Collections.Generic;
using System.Text;
using Kalaha.Models;
using ReactiveUI;

namespace Kalaha.ViewModels
{
    public class PlayViewModel : ViewModelBase
    {
        private Board board;


        public PlayViewModel()
        {
            Board = new Board(6,4);
        }

        public Board Board
        {
            get { return board; }
            set { this.RaiseAndSetIfChanged(ref board, value); }
        }
    }
}
