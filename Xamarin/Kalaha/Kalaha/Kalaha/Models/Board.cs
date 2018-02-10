using System.Linq;
using System.Reactive.Linq;
using ReactiveUI;

namespace Kalaha.Models
{
    public class Board : ReactiveObject
    {
        public Board(byte houses, byte initialCount)
        {
            South = new Side(Observable.Return(true), houses, initialCount);
            North = new Side(Observable.Return(true), houses, initialCount);
            South.Store.Next = North.Houses.First();
            North.Store.Next = South.Houses.First();
            for (var i = 0; i < houses; i++)
            {
                South.Houses[i].Opposite = North.Houses[houses - 1 - i];
                North.Houses[i].Opposite = South.Houses[houses - 1 - i];
            }
        }

        public Side South { get; }

        public Side North { get; }
    }
}