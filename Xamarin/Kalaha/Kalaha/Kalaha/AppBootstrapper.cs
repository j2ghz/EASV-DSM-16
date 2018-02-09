using System;
using Kalaha.Models;
using Kalaha.ViewModels;
using Kalaha.Views;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace Kalaha
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; protected set; }

        public AppBootstrapper()
        {
            var board = new Board(6,4);
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
            Locator.CurrentMutable.Register(() => new HighScores(), typeof(IViewFor<HighScoresViewModel>));
            Locator.CurrentMutable.Register(() => new HighScoresViewCell(), typeof(IViewFor<HighScores>));
            //Locator.CurrentMutable.Register(() => new MovieDetailView(), typeof(IViewFor<MovieDetailViewModel>));

            //Locator.CurrentMutable.Register(() => new Cache(), typeof(ICache));
            //Locator.CurrentMutable.Register(() => new ApiService(), typeof(IApiService));


            this
                .Router
                .NavigateAndReset
                .Execute(new HighScoresViewModel())
                .Subscribe();
        }

        public Page CreateMainPage()
        {
            // NB: This returns the opening page that the platform-specific
            // boilerplate code will look for. It will know to find us because
            // we've registered our AppBootstrappScreen.
            return new RoutedViewHost();
        }
    }
}