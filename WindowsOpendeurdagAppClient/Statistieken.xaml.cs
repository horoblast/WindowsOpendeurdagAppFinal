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
    public sealed partial class Statistieken : Page
    {
        public Statistieken()
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

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // system.net import!!
            HttpClient client = new HttpClient();
            var jsonstring = await client.GetStringAsync(new Uri("http://localhost:64288/api/gebruikerformuliers"));
            //json nuget package!!
            var lst = JsonConvert.DeserializeObject<ObservableCollection<GebruikerFormulier>>(jsonstring);
            var totaal = lst.Count;
            var aantalAalst = 0;
            var aantalBijloke = 0;
            var aantalLedeganck = 0;
            var aantalMelle = 0;
            var aantalMercator = 0;
            var aantalBedrijfsmanagement = 0;
            var aantalOfficemanagement = 0;
            var aantalRetailmanagement = 0;
            var aantalTIN = 0;
            foreach (GebruikerFormulier formulier in lst)
            {
                try { 
                if (formulier.Campus.ToLower().Contains("aalst"))
                {
                    aantalAalst++;
                } else if (formulier.Campus.ToLower().Contains("bijloke"))
                {
                    aantalBijloke++;
                }
                else if (formulier.Campus.ToLower().Contains("ledeganck"))
                {
                    aantalLedeganck++;
                }
                else if (formulier.Campus.ToLower().Contains("melle"))
                {
                    aantalMelle++;
                }
                else if (formulier.Campus.ToLower().Contains("mercator"))
                {
                    aantalMercator++;
                }

                if (formulier.Richting.ToLower().Contains("bedrijf"))
                {
                    aantalBedrijfsmanagement++;
                }
                else if (formulier.Richting.ToLower().Contains("office"))
                {
                    aantalOfficemanagement++;
                }
                else if (formulier.Richting.ToLower().Contains("retail"))
                {
                    aantalRetailmanagement++;
                }
                else if (formulier.Richting.ToLower().Contains("informatica"))
                {
                    aantalTIN++;
                }
                }catch(NullReferenceException ex)
                {
                    
                }
                Ttotaal.Text = ""+ totaal;
                TaantalAalst.Text = "" + aantalAalst;
                TaantalBedrijfsmanagement.Text = "" + aantalBedrijfsmanagement;
                TaantalBijloke.Text = "" + aantalBijloke;
                TaantalLedeganck.Text = "" + aantalLedeganck;
                TaantalMelle.Text = "" + aantalMelle;
                TaantalMercator.Text = "" + aantalMercator;
                TaantalRetailmanagement.Text = "" + aantalRetailmanagement;
                TaantalTIN.Text = "" + aantalTIN;
                TaantalOfficemanagement.Text = "" + aantalOfficemanagement;
            }
        }
    }
}
