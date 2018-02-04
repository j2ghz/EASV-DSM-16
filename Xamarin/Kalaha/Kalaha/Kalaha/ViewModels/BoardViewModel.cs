using System;
using System.Collections.Generic;
using System.Text;
using Kalaha.Models;

namespace Kalaha.ViewModels
{
    public class BoardViewModel : ViewModelBase
    {
        public Board Board { get; }

        public BoardViewModel(Board board)
        {
            this.Board = board;
        }
    }
}
