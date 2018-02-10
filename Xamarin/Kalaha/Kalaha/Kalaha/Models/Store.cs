using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace Kalaha.Models
{
    public class Store : Cell
    {
        public Store(IObservable<bool> belongsToActiveSideObservable) : base(belongsToActiveSideObservable, 0)
        {
        }

        public override ReactiveCommand StartMovingSeeds { get; } = ReactiveCommand.Create(() => { }, Observable.Return(false));

        public override void MoveSeeds(byte seedCount)
        {
            Seeds++;
            if (seedCount == 1)
                return;
            Next.MoveSeeds(--seedCount);
        }
    }
}