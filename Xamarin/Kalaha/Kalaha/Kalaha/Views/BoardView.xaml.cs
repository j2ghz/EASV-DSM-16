using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalaha.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kalaha.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BoardView : ReactiveContentView<BoardViewModel>
	{
		public BoardView ()
		{
			InitializeComponent ();

		    this.WhenActivated(disposables =>
		    {
		        //this.OneWayBind(ViewModel, x => x.Board.CellOwn, x => x.CellOwn);
		    });
		}
	}
}