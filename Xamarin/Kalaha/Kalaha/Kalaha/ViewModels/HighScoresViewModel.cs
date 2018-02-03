using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Akavache;
using DynamicData;
using DynamicData.Binding;
using Kalaha.Models;
using ReactiveUI;
using DynamicData.ReactiveUI;

namespace Kalaha.ViewModels
{
    public class HighScoresViewModel : ViewModelBase
    {
        private readonly ReactiveList<HighScore> highScores = new ReactiveList<HighScore>();
        public HighScoresViewModel()
        {
            BlobCache.UserAccount.GetOrFetchObject("highscores",
                    () => Observable.Return(new List<HighScore>
                    {
                        new HighScore {Name = "Test", Date = DateTime.Now, Score = 1}
                    }))
                .ToObservableChangeSet<HighScore>()
                .Sort(SortExpressionComparer<HighScore>.Descending(h=>h.Score))
                .Bind(highScores)
                .Subscribe()
                .DisposeWith(_cleanup);
        }

        public IReadOnlyReactiveList<HighScore> HighScores => highScores;
    }
}