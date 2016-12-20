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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsOpendeurdagAppClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ImageSource();
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

}
