using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLite
{
	public partial class MainPage : ContentPage
	{
	    private readonly SQLiteAsyncConnection db;

	    public MainPage(SQLiteAsyncConnection conn)
		{
			InitializeComponent();
		    db = conn;
            Init();
		}

	    private async void Init()
	    {
	        var starts = await db.Table<Start>().ToListAsync();
            Label.Text = string.Join(Environment.NewLine,starts.Select(s=>s.Time));

	    }
	}
}
