using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using Akavache;
using DynamicData;
using Kalaha.Models;

namespace Kalaha.ViewModels
{
    public class HighScoresViewModel : ViewModelBase
    {
        public HighScoresViewModel()
        {
            HighScores = BlobCache.UserAccount.GetOrFetchObject("highscores",
                    () => Observable.Return(new List<HighScore>
                    {
                        new HighScore {Name = "Test", Date = DateTime.Now, Score = 1}
                    }))
                .ToObservableChangeSet<HighScore>();
        }

        public IObservable<IChangeSet<HighScore>> HighScores { get; }
    }
}