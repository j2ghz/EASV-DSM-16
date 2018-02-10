using System;

namespace Kalaha.Models
{
    public class House : Cell
    {
        public House(IObservable<bool> belongsToActiveSideObservable, byte initialCount) : base(
            belongsToActiveSideObservable, initialCount)
        {
        }

        public House Opposite { get; set; }

        public override void MoveSeeds(byte seedCount)
        {
            Seeds++;
            if (seedCount <= 0)
            {
                //switch player
            }
            if (seedCount == 1)
                return;
            Next.MoveSeeds(--seedCount);
        }
    }
}