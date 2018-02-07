using ReactiveUI;

namespace Kalaha.Models
{
    public abstract class Cell : ReactiveObject
    {
        protected Cell()
        {
            var canMove = this.WhenAnyValue(x => x.Seeds, x => x.Next, (seeds, next) => seeds > 0 && next != null);
            StartMovingSeeds = ReactiveCommand.Create(MoveSeeds, canMove);
        }

        public Cell Next { get; set; }
        public byte Seeds { get; set; }

        public ReactiveCommand StartMovingSeeds { get; }

        private void MoveSeeds()
        {
            var seeds = Seeds;
            Seeds = 0;
            Next.MoveSeeds(seeds);
        }

        public abstract void MoveSeeds(byte seedCount);
    }
}