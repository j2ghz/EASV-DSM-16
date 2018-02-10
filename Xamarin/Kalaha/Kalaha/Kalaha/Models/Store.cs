using System;

namespace Kalaha.Models
{
    public class Store : Cell
    {
        public Store(IObservable<bool> belongsToActiveSideObservable) : base(belongsToActiveSideObservable, 0)
        {
        }

        public override void MoveSeeds(byte seedCount)
        {
            Seeds++;
            if (seedCount == 1)
                return;
            Next.MoveSeeds(--seedCount);
        }
    }
}