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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsOpendeurdagAppClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SchoonmeersenRondleiding : Page
    {
        public SchoonmeersenRondleiding()
        {
            this.InitializeComponent();
        }
        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Schoonmeersen), null);
        }

        private void StackPanel_Tapped_Gelijkvloers(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Gelijkvloers), null);
        }

        private void StackPanel_Tapped_Eerste_verdieping(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EersteVerdieping), null);
        }

        private void StackPanel_Tapped_Tweede_verdieping(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TweedeVerdieping), null);
        }

        private void StackPanel_Tapped_Derde_verdieping(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DerdeVerdieping), null);
        }

        private void StackPanel_Tapped_Vierde_verdieping(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VierdeVerdieping), null);
        }

    }
}
