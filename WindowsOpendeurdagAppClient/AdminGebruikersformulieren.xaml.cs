using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WindowsOpendeurdagAppWeb.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsOpendeurdagAppClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminGebruikersformulieren : Page
    {
        public AdminGebruikersformulieren()
        {
            this.InitializeComponent();
        }

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminLogin), null);
        }

        private void adminlogout_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        // get request
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // system.net import!!
            HttpClient client = new HttpClient();
            var jsonstring = await client.GetStringAsync(new Uri("http://localhost:64288/api/gebruikerformuliers"));
            //json nuget package!!
            var lst = JsonConvert.DeserializeObject<ObservableCollection<GebruikerFormulier>>(jsonstring);
            lvformulieren.ItemsSource = lst;
        }
    }

    public class StringFormatConverterAdminGebruikerFormulieren : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return null;

            if (parameter == null)
                return value;

            return string.Format((string)parameter, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
