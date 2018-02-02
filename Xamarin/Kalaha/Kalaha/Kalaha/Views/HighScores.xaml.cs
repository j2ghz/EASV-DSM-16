using System.Reactive.Disposables;
using Kalaha.ViewModels;
using Kalaha.Views;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace Kalaha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HighScores : ContentPageBase<HighScoresViewModel>
    {
        public HighScores()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.HighScores, x => x.HighScoreList.ItemsSource)
                    .DisposeWith(disposables);
            });
        }
    }
}