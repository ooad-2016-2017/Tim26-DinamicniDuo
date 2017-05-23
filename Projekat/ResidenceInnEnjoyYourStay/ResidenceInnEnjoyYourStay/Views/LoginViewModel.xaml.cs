using System;

using System.Collections.Generic;
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
    public sealed partial class LoginViewModel : Page
    {
        public LoginViewModel()
        {
            this.InitializeComponent();
           // var inicijalizacija = new DataSourceMenuMD();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgotPassword), null);
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija), null);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaStrana), null);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaStrana), null);
        }
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            var korisnickoIme = textBoxUser.Text;
            var sifra = textBoxPass.Password;
            bool login = true;

            if (login)
            {
                this.Frame.Navigate(typeof(PocetnaStrana), null);
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješna prijava");
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
