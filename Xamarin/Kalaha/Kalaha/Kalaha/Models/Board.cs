using System;
using System.Linq;
using System.Reactive.Linq;
using ReactiveUI;

namespace Kalaha.Models
{
    public class Board : ReactiveObject
    {
        private readonly IObservable<bool> currentPlayer =
            Observable
                .Interval(TimeSpan.FromSeconds(5))
                .Select(i => i % 2 == 0)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Publish().RefCount();

        public Board(byte houses, byte initialCount)
        {
            South = new Side(currentPlayer.Select(v => !v), houses, initialCount);
            North = new Side(currentPlayer, houses, initialCount);
            South.Store.Next = North.Houses.Last();
            North.Store.Next = South.Houses.First();
            for (var i = 0; i < houses; i++)
            {
                South.Houses[i].Opposite = North.Houses[houses - 1 - i];
                North.Houses[i].Opposite = South.Houses[houses - 1 - i];
            }
            for (var i = 0; i <= North.Houses.Count - 2; i++)
            {
                North.Houses[i + 1].Next = North.Houses[i];
            }
            North.Houses.First().Next = North.Store;
            for (var i = 0; i <= South.Houses.Count - 2; i++)
            {
                South.Houses[i].Next = South.Houses[i+1];
            }
            South.Houses.Last().Next = South.Store;
        }

        public Side South { get; }

        public Side North { get; }
    }
}