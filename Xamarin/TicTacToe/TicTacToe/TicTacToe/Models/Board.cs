using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Models
{
    public class Board
    {
        public readonly IReadOnlyList<IReadOnlyList<Cell>> board;

        public Board(byte count)
        {
            board = Enumerable
                .Range(0, count)
                .Select(r =>
                    Enumerable
                        .Range(0, count)
                        .Select(c => new Cell()).ToList())
                .ToList();
        }

        public void CheckWinner()
        {
            throw new NotImplementedException();
        }

    }
}