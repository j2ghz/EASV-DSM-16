using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        private string currentPlayer = "X";

        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            btn.Text = currentPlayer;
            currentPlayer = currentPlayer == "X" ? "O" : "X";
            CurerntPlayer.Text = currentPlayer;
        }
    }
}