using Microsoft.WindowsAzure.MobileServices;
using ResidenceInnEnjoyYourStay.Azure;
using ResidenceInnEnjoyYourStay.ViewModels;
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
    public sealed partial class Registracija : Page
    {
        public string text { get; set; }
        public Registracija()
        {
            this.InitializeComponent();
            this.DataContext = new RegisterViewModel();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            text = e.Parameter as string;
            if (text != null)
            {
                textBlock12.Text = text;
                //Do your stuff
            }
        }
        IMobileServiceTable<RegistrovaniKorisnik> userTableObj = App.MobileService.GetTable<RegistrovaniKorisnik>();
        private void buttonRegistrujSe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegistrovaniKorisnik obj = new RegistrovaniKorisnik();
                obj.ime = textBoxIme.Text;
                obj.prezime = textBoxPrezime.Text;
                obj.email = textBoxEmail.Text;
                obj.password = passwordBoxSifra.Password;
                obj.username = textBoxKorisnik.Text;
                obj.datumRodjenja = new DateTime(1995, 5, 15);
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste registrovani.");

                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " +
               ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

    
    }
}

//Command="{Binding RegisterCommand}"
