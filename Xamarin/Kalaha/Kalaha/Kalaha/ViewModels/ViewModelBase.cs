using System;
using System.Reactive.Disposables;
using ReactiveUI;
using Splat;

namespace Kalaha.ViewModels
{
    public class ViewModelBase : ReactiveObject, IRoutableViewModel, ISupportsActivation, IDisposable
    {
        protected readonly CompositeDisposable _cleanup = new CompositeDisposable();

        protected readonly ViewModelActivator viewModelActivator = new ViewModelActivator();

        public ViewModelBase(IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }

        public void Dispose()
        {
            _cleanup.Dispose();
        }

        public IScreen HostScreen { get; protected set; }


        public string UrlPathSegment { get; protected set; }

        public ViewModelActivator Activator => viewModelActivator;
    }
}