using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Xaml.Documents;
using System.ComponentModel;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using System.Windows.Input;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsOpendeurdagAppClient
{
    
    public sealed partial class Nieuws : Page
    {
        public Nieuws()
        {
            this.InitializeComponent();
        }

        DispatcherTimer playlistTimer = null;
        List<string> nieuwsItems = new List<string>();

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ImageSource();

            var auth = new ApplicationOnlyAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = "j0zFBHzMkUYILNTbSojbFyPRQ",
                    ConsumerSecret = "aTS41DXzkDxt9j7JJxjBwdHZDut1am20356q9nuuRlqORj7a2O",
                }

            };
            await auth.AuthorizeAsync();
            var twitterContext = new TwitterContext(auth);

            string twitterfeed = "Hogeschool_Gent";

            Search searchResponse =
                await
                (from search in twitterContext.Search
                 where search.Type == SearchType.Search &&
                       search.Query == twitterfeed
                 select search)
                .SingleOrDefaultAsync();

            List<TweetViewModel> tweets =
               (from tweet in searchResponse.Statuses
                select new TweetViewModel
                {
                    ImageUrl = tweet.User.ProfileImageUrl,
                    ScreenName = tweet.User.ScreenNameResponse,
                    Text = tweet.Text
                })
               .ToList();

            tweetListView.ItemsSource = new ObservableCollection<TweetViewModel>(tweets);
        }


      
        private void ImageSource()
        {
            nieuwsItems.Add("skireis.jpg");
            nieuwsItems.Add("unitedcolorsofghent.jpg");
            playlistTimer = new DispatcherTimer();
            playlistTimer.Interval = new TimeSpan(0, 0, 5);
            playlistTimer.Tick += playlistTimer_Tick;
            nieuwsBtn.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + nieuwsItems[count]));
            playlistTimer.Start();
        }
        int count = 0;
        void playlistTimer_Tick(object sender, object e)
        {
            if (nieuwsItems != null)
            {
                if (count < nieuwsItems.Count)
                {
                    count++;
                }
                if (count >= nieuwsItems.Count) { 
                    count = 0;
                }
                ImageRotation();
            }
        }
        private void ImageRotation()
        {
            nieuwsBtn.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + nieuwsItems[count].ToString()));
        }
    }

    public class TweetViewModel
    {
        public string ImageUrl { get; set; }

        public string ScreenName { get; set; }

        public string Text { get; set; }
    }
}
