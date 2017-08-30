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

        private async void addevent_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // aanmaken invoervelden van het calendar event
            var calevent = new CalendarEvent() { Name = "", Adres = "", ForWhom = "", DayOfEvent = new DateTime(2016, 12, 31, 0, 0, 0), Time = "" };

            // aanmaken post call naar DB om de nieuwe calendarevent op te slaan if confirm event button is tapped
            var caleventJson = JsonConvert.SerializeObject(calevent);

            HttpClient client = new HttpClient();

            var res = await client.PostAsync("http://localhost:64288/api/calendarevents", new
                StringContent(caleventJson, System.Text.Encoding.UTF8, "application/json"));

            this.Frame.Navigate(typeof(AdminAgenda), null);
        }

        private async void tbupdate_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var item = sender as Button;
            var data = item.DataContext;
            var id = ((CalendarEvent)data).CalendarEventId;

            var weburiupdate = "http://localhost:64288/api/calendarevents/" + id;

            HttpClient client = new HttpClient();

            var jsonstring = await client.GetStringAsync(new Uri(weburiupdate));
            CalendarEvent caleventjson = JsonConvert.DeserializeObject<CalendarEvent>(jsonstring);

            CalendarEvent calevent = ((CalendarEvent)data);

            caleventjson.Name = calevent.Name;
            caleventjson.Adres = calevent.Adres;
            caleventjson.ForWhom = calevent.ForWhom;
            caleventjson.DayOfEvent = calevent.DayOfEvent;
            caleventjson.Time = calevent.Time;

            string caleventupdated = JsonConvert.SerializeObject(caleventjson);

            var res = await client.PutAsync(weburiupdate, new StringContent(caleventupdated, System.Text.Encoding.UTF8, "application/json"));

            this.Frame.Navigate(typeof(AdminAgenda), null);
        }

        private async void tbdelete_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var item = sender as Button;
            var data = item.DataContext;
            
            var id = ((CalendarEvent)data).CalendarEventId;
            
            var weburidelete = "http://localhost:64288/api/calendarevents/" + id;

            HttpClient client = new HttpClient();

            var res = await client.DeleteAsync(weburidelete);

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
            var datestring = (string)value;
            return DateTime.Parse(datestring);
        }
    }
}
