using System;
using System.Linq;
using DynamicData.Binding;
using ReactiveUI;

namespace Kalaha.Models
{
    public class Side : ReactiveObject
    {
        public Side(IObservable<bool> belongsToActiveSideObservable, byte houses, byte initialCount, Action played)
        {
            Store = new Store(belongsToActiveSideObservable);
            Houses = new ObservableCollectionExtended<House>(Enumerable.Range(0, houses)
                .Select(i => new House(belongsToActiveSideObservable, initialCount, played)));
        }

        public Store Store { get; }

        public ObservableCollectionExtended<House> Houses { get; set; }
    }
}