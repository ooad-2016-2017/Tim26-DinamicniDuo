using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ResidenceInnEnjoyYourStay.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page, INotifyPropertyChanged
    {
        public Registracija()
        {
            this.InitializeComponent();
        }
        public String text2 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginViewModel), null);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaStrana), null);
        }
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            var korisnickoIme = textBoxKorisnik.Text;
            var sifra = passwordBoxSifra.Password;
            var potvrdi = passwordBoxPotvrdi.Password;
            var ime = textBoxIme.Text;
            var prezime = textBoxPrezime.Text;

            
            bool login = true;

            if (login)
            {
                textBlock12.Visibility = Visibility.Visible;
                text2 = "text";
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(text2)));
                }
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno!", "Neuspješna registracija");
                await dialog.ShowAsync();
            }

            /*var korisnik = DataSourceMenuMD.ProvjeraKorisnika(korisnickoIme, sifra);
            if (korisnik != null && korisnik.KorisnikId > 0)
            {
                this.Frame.Navigate(typeof(MainPage), korisnik);
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješna
               prijava");
               
                await dialog.ShowAsync();
            }*/
        }
    }
}
