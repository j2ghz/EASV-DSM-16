using System;
using ReactiveUI;

namespace Kalaha.Models
{
    public abstract class Cell : ReactiveObject
    {
        private byte seeds;

        protected Cell(IObservable<bool> belongsToActiveSideObservable, byte initialCount)
        {
            Seeds = initialCount;
        }

        public Cell Next { get; set; }

        public byte Seeds
        {
            get => seeds;
            protected set => this.RaiseAndSetIfChanged(ref seeds, value);
        }

        public abstract ReactiveCommand StartMovingSeeds { get; }

        public abstract void MoveSeeds(byte seedCount);
    }
}