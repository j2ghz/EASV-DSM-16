using System;
using System.Linq;
using DynamicData.Binding;
using ReactiveUI;

namespace Kalaha.Models
{
    public class Side : ReactiveObject
    {
        public Side(IObservable<bool> belongsToActiveSideObservable, byte houses, byte initialCount)
        {
            Store = new Store(belongsToActiveSideObservable);
            Houses = new ObservableCollectionExtended<House>(Enumerable.Range(0, houses)
                .Select(i => new House(belongsToActiveSideObservable, initialCount)));
            Houses.Last().Next = Store;
            for (var i = Houses.Count - 2; i >= 0; i--)
                Houses[i].Next = Houses[i + 1];
        }

        public Store Store { get; }

        public ObservableCollectionExtended<House> Houses { get; }
    }
}