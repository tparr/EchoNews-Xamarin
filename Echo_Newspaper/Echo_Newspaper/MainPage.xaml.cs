using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Echo_Newspaper
{
	public partial class MainPage : ContentPage
	{
	    public ObservableCollection<ArticleViewModel> Articles { get; set; }

		public MainPage()
		{
		    InitializeComponent();

		    Articles = new ObservableCollection<ArticleViewModel>
		    {
		        new ArticleViewModel {Title = "Title1", Date = "Today", Image = @"C:\Users\tparr\Documents\Visual Studio 2017\Projects\Echo_Newspaper\Echo_Newspaper\Echo_Newspaper\Headshot.jpg"},
		        new ArticleViewModel {Title = "Title2", Date = "Yesterday", Image = "No Image"},
		        new ArticleViewModel {Title = "Title3", Date = "2 Days Ago", Image = "No Image"}
		    };

		    listView.ItemsSource = Articles;
		}
	}
}
