using System;
using System.Collections.Generic;
using System.Text;

namespace Kalaha.Models
{
    public class House : Cell
    {
        public override void MoveSeeds(byte seedCount)
        {
            Seeds++;
            switch (seedCount)
            {
                case 0:

                    break;
            }
            Next.MoveSeeds(--seedCount);
        }
    }
}
