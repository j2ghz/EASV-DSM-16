using ReactiveUI;

namespace Kalaha.Models
{
    public class Side : ReactiveObject
    {
        private IReadOnlyReactiveList<House> houses;
        private Store store;

        public Store Store
        {
            get => store;
            set => this.RaiseAndSetIfChanged(ref store, value);
        }

        public IReadOnlyReactiveList<House> Houses
        {
            get => houses;
            set => this.RaiseAndSetIfChanged(ref houses, value);
        }
    }
}