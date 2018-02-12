using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
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
	public partial class CellView : ReactiveContentView<Kalaha.Models.Cell>
	{
		public CellView ()
		{
			InitializeComponent ();
		    
		    this.WhenActivated(disposable =>
		    {
		        this.OneWayBind(ViewModel, x => x.Seeds, x => x.Button.Text).DisposeWith(disposable);
		        this.BindCommand(ViewModel, x => x.StartMovingSeeds, x => x.Button).DisposeWith(disposable);
		        if (Button.Command != null)
		            Button.Command.CanExecuteChanged += (sender, args) => Debug.WriteLine(Button.Command.CanExecute(null));
		    });
		}
	}
}