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
    public sealed partial class AdminAgenda : Page
    {
        public AdminAgenda()
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
            var jsonstring = await client.GetStringAsync(new Uri("http://localhost:64288/api/calendarevents"));
            //json nuget package!!
            var lst = JsonConvert.DeserializeObject<ObservableCollection<CalendarEvent>>(jsonstring);
            lvagenda.ItemsSource = lst;
        }

        private async void agendaupdate_Click(object sender, RoutedEventArgs e)
        {
            /*var form = new CalendarEvent
            {
                Name = this.tbevent.Text,
                Adres = this.tbplaats.Text,
                ForWhom = this.tbdoelgroep.Text,
                DayOfEvent = Convert.ToDateTime(this.tbdatum.Text),
                Time = this.tbtijd.Text,
            };
            HttpClient client = new HttpClient();
            var formJson = JsonConvert.SerializeObject(form);
            var res = await client.PutAsync("http://localhost:64288/api/calendarevents", new
                StringContent(formJson, System.Text.Encoding.UTF8, "application/json"));*/

        }

        private async void addevent_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var calevent = new CalendarEvent() { Name = "AddName", Adres = "AddAdres", ForWhom = "AddForWhom", DayOfEvent = new DateTime(2016, 12, 31, 0, 0, 0), Time = "AddTime" };
            var caleventJson = JsonConvert.SerializeObject(calevent);

            HttpClient client = new HttpClient();

            var res = await client.PostAsync("http://localhost:64288/api/calendarevents", new
                StringContent(caleventJson, System.Text.Encoding.UTF8, "application/json"));

            this.Frame.Navigate(typeof(AdminAgenda), null);
        }
    }

    public class StringFormatConverterAdmin : IValueConverter
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
