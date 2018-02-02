using System.Reactive.Disposables;
using Kalaha.Models;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace Kalaha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HighScoresViewCell : ReactiveViewCell<HighScore>
    {
        protected readonly CompositeDisposable SubscriptionDisposables = new CompositeDisposable();

        public HighScoresViewCell()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.Name, x => x.Name.Text).DisposeWith(SubscriptionDisposables);
                this.OneWayBind(ViewModel, x => x.Date, x => x.Date.Text).DisposeWith(SubscriptionDisposables);
                this.OneWayBind(ViewModel, x => x.Score, x => x.Score.Text).DisposeWith(SubscriptionDisposables);
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            SubscriptionDisposables.Clear();
        }
    }
}