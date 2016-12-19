using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public sealed partial class GebruikerFormuliers : Page
    {
        HttpClient client;

        public GebruikerFormuliers()
        {
            this.InitializeComponent();
        }

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private async void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            client = new HttpClient();
            try
            {
                 
                GebruikerFormulier form = new GebruikerFormulier {
                    Voornaam = this.voornaam.Text,
                    Achternaam = this.achternaam.Text,
                    Geboortedatum = DateTime.Parse(this.geboortedatum.ToString()),
                    Straat = this.adres.Text,
                    Email = this.email.Text,
                    Telnr = int.Parse(this.gsmnummer.Text),
                    Campus = this.campus.SelectedItem.ToString(),
                    Richting = this.opleiding.SelectedItem.ToString()
    };
                var formJson = JsonConvert.SerializeObject(form);
                var res = await client.PostAsync("http://localhost:64288/api/gebruikerformuliers", new
                    StringContent(formJson, System.Text.Encoding.UTF8, "application/json"));
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }
        }
    }
}
