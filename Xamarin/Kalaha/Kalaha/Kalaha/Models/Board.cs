using ReactiveUI;

namespace Kalaha.Models
{
    public class Board : ReactiveObject
    {
        private Side north;
        private Side south;

        public Side South
        {
            get => south;
            set => this.RaiseAndSetIfChanged(ref south, value);
        }

        public Side North
        {
            get => north;
            set => this.RaiseAndSetIfChanged(ref north, value);
        }
    }
}