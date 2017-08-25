using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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

        public GebruikerFormuliers()
        {
            this.InitializeComponent();
        }

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            try {
                EmailAddressAttribute em = new EmailAddressAttribute();
                
                if (this.voornaam.Text.Equals(String.Empty) || this.achternaam.Text.Equals(String.Empty) || this.adres.Text.Equals(String.Empty)
                   || this.email.Text.Equals(String.Empty) || this.gsmnummer.Text.Equals(String.Empty))
                {
                    error.Text = "Niet alle gegevens zijn ingevuld!";
                }
                else if (!this.voornaam.Text.All(Char.IsLetter))
                {
                    error.Text = "Voornaam mag enkel uit letters bestaan!";
                }
                else if (!this.achternaam.Text.All(Char.IsLetter))
                {
                    error.Text = "Achternaam mag enkel uit letters bestaan!";
                }
                else if (!em.IsValid(email.Text))
                {
                    error.Text = "Gelieve een correct emailadres op te geven!";
                }
                else if (!this.gsmnummer.Text.All(Char.IsNumber))
                {
                    error.Text = "GSM nummer mag enkel uit cijfers bestaan!";
                }
                else if (this.gsmnummer.Text.Length !=10)
                {
                    error.Text = "Een geldig GSM nummer bestaat uit 10 cijfers!";
                }
                else { 
                var form = new GebruikerFormulier
            {
                Voornaam = this.voornaam.Text,
                Achternaam = this.achternaam.Text,
                Geboortedatum = this.geboortedatum.Date.ToString("dd/MM/yyyy"),
                    Straat = this.adres.Text,
                    Email = this.email.Text,
                    Telnr = 1 + int.Parse(this.gsmnummer.Text),
                    Campus = this.campus.SelectedItem.ToString(),
                    Richting = this.opleiding.SelectedItem.ToString()
                };
                HttpClient client = new HttpClient();
                var formJson = JsonConvert.SerializeObject(form);
                var res = await client.PostAsync("http://localhost:64288/api/gebruikerformuliers", new
                    StringContent(formJson, System.Text.Encoding.UTF8, "application/json"));
            voornaam.Text = string.Empty;
            achternaam.Text = string.Empty;
            adres.Text = string.Empty;
            email.Text = string.Empty;
            gsmnummer.Text = string.Empty;
            campus.SelectedIndex = 0;
            opleiding.SelectedIndex = 0;
            geboortedatum.Date = DateTime.Now;
            error.Text = "";

                //successmessage
                successmessage.Visibility = Visibility.Visible;
                }

            }
            catch (Exception ex)
            {
                error.Text = "Oops, er ging iets fout !";
            }
        }
    }
}
