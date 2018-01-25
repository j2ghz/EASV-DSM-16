using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentView : ContentPage
	{
		public StudentView (Student student)
		{
			InitializeComponent ();
		    this.BindingContext = student;
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PopAsync();
	    }
	}
}