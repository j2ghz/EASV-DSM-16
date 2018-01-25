using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest1
{
	public partial class MainPage : ContentPage
	{
        private ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>(){ new Student() { Grade = 2, Name = "Test" } , new Student() { Grade = 1, Name = "2" } , new Student() { Grade = 3, Name = "Test2" } };
		public MainPage()
		{
			InitializeComponent();
		    this.BindingContext = Students;
		}

	    private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        await Navigation.PushAsync(new StudentView(e.SelectedItem as Student), true);
	    }
	}
}
