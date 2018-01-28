using System.Windows.Input;
using TicTacToe.Models;
using Xamarin.Forms;
using Cell = TicTacToe.Models.Cell;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        private Board board = new Board(3);
        public ICommand BoardClicked;
        private Player CurrentPlayer;

        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
            BoardClicked = new Command<Cell>(cell => cell.Player = CurrentPlayer);
        }
    }
}