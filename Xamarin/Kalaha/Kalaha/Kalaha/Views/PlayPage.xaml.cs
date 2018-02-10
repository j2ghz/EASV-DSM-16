using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using Kalaha.ViewModels;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kalaha.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlayPage : ContentPageBase<PlayViewModel>
	{
		public PlayPage ()
		{
			InitializeComponent ();

		    this.WhenActivated(disposable =>
		    {
		        this.OneWayBind(ViewModel, x => x.Board, x => x.BoardView.ViewModel).DisposeWith(disposable);
		    });
		}
	}
}