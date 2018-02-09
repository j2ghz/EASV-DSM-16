using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using Kalaha.Models;
using Kalaha.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kalaha.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BoardView : ReactiveContentView<Board>
	{
		public BoardView ()
		{
			InitializeComponent ();

		    this.WhenActivated(disposables =>
		    {
		        this.OneWayBind(ViewModel, x => x.North.Store, x => x.NorthStore.ViewModel).DisposeWith(disposables);
                this.OneWayBind(ViewModel, x => x.North.Houses[0], x => x.North1.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.North.Houses[1], x => x.North2.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.North.Houses[2], x => x.North3.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.North.Houses[3], x => x.North4.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.North.Houses[4], x => x.North5.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.North.Houses[5], x => x.North6.ViewModel).DisposeWith(disposables);

		        this.OneWayBind(ViewModel, x => x.South.Store, x => x.SouthStore.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.South.Houses[0], x => x.South1.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.South.Houses[1], x => x.South2.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.South.Houses[2], x => x.South3.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.South.Houses[3], x => x.South4.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.South.Houses[4], x => x.South5.ViewModel).DisposeWith(disposables);
		        this.OneWayBind(ViewModel, x => x.South.Houses[5], x => x.South6.ViewModel).DisposeWith(disposables);
            });
		}
	}
}