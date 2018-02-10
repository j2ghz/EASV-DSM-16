using System.Reactive.Disposables;
using Kalaha.Models;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace Kalaha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoardView : ReactiveContentView<Board>
    {
        public BoardView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.North.Store, x => x.NorthStore.ViewModel)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel, x => x.North.Houses, x => x.NorthHouses.ItemsSource)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel, x => x.South.Store, x => x.SouthStore.ViewModel)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel, x => x.South.Houses, x => x.SouthHouses.ItemsSource)
                    .DisposeWith(disposables);
            });
        }
    }
}