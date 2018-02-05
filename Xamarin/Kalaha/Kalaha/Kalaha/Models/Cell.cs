using ReactiveUI;

namespace Kalaha.Models
{
    public abstract class Cell : ReactiveObject
    {
        public Cell Next { get; set; }
        public byte Seeds { get; set; }

        public void MoveSeeds()
        {
            var seeds = Seeds;
            Seeds = 0;
            Next.MoveSeeds(seeds);
        }

        public abstract void MoveSeeds(byte seedCount);
    }
}