using System;
using Xamarin.Forms;

namespace CatchTheMouse
{
    public partial class MainPage : ContentPage
    {
        private readonly Random r = new Random();
        private DateTime Start;
        private int counter = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            if (Start == default(DateTime))
            {
                Start = DateTime.Now;
            }
            else
            {
                counter++;
            }
            if (counter >= 20)
            {
                await DisplayAlert("Done", (DateTime.Now - Start).ToString(), "Dismiss");
            }
            AbsoluteLayout.SetLayoutBounds(Button, new Rectangle(r.NextDouble(), r.NextDouble(), 0.01, 0.01));
            
        }
    }
}