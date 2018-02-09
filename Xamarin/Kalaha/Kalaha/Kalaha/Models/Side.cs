using System;
using System.Linq;
using ReactiveUI;

namespace Kalaha.Models
{
    public class Side : ReactiveObject
    {
        private IReadOnlyReactiveList<House> houses;
        private Store store;

        public Side(IObservable<bool> belongsToActiveSideObservable, byte houses, byte initialCount)
        {
            Store=new Store(belongsToActiveSideObservable);
            Houses=new ReactiveList<House>(Enumerable.Range(0, houses).Select(i => new House(belongsToActiveSideObservable, initialCount)));
            Houses.Last().Next = Store;
            for (var i = Houses.Count-2; i >= 0 ; i--)
            {
                Houses[i].Next = Houses[i + 1];
            }
        }
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