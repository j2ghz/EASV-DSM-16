using ReactiveUI;

namespace Kalaha.Models
{
    public class Cell : ReactiveObject
    {
        public Cell Next { get; set; }
        public byte Seeds { get; set; }

        public void MoveSeeds()
        {
        }

        public void MoveSeeds(byte seedCount)
        {
            Seeds++;
            if (seedCount > 0)
                Next.MoveSeeds(--seedCount);
            //if end at own house, one more move
            //maybe different types for house/store?

        }
    }
}