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
		        new ArticleViewModel {Title = "De-stressing throughout dead week", Date = "Today", Description = "Meet this week's winnersCongratulations to freshman Emily Klingstein for first place!   In second...",Image = "Headshot.jpg"},
		        new ArticleViewModel {Title = "The Great Christmas Tree Contest", Date = "Yesterday", Description = "Counseling Center organizes activities to help decrease stressBy Chin Yi Oh | Echo The Counseling Center...", Image = "Headshot.jpg"},
		        new ArticleViewModel {Title = "The Echo wins two HSPA awards", Date = "2 Days Ago", Description = "Echo Last weekend, the staff members of The Echo represented Taylor at the Hoosier...", Image = "Headshot.jpg"}
		    };

		    listView.ItemsSource = Articles;
		}
	}
}
