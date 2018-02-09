using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalaha.ViewModels;
using ReactiveUI.XamForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kalaha.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CellView : ReactiveContentView<CellViewModel>
	{
		public CellView ()
		{
			InitializeComponent ();
		}
	}
}