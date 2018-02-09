using System;
using System.Collections.Generic;
using System.Text;

namespace Kalaha.Models
{
    public class House : Cell
    {
        public House(IObservable<bool> belongsToActiveSideObservable, byte initialCount) : base(belongsToActiveSideObservable, initialCount)
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
            {
                //get seed from this house and the opposite house, and move them to player's storage
                return;
            }
            Next.MoveSeeds(--seedCount);
        }
    }
}
