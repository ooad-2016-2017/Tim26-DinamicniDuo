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
    public sealed partial class ForgotPassword : Page, INotifyPropertyChanged
    {
        public String text { get; set; }
        public ForgotPassword()
        {
            this.InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaStrana), null);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginViewModel), null);
        }
        private async void btn_resetClick(object sender, RoutedEventArgs e)
        {
           
            var sifra = textBox.Text;
            bool login = true;

            if (login)
            {
                textBlock3.Visibility = Visibility.Visible;
                text = "text";
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(text)));
                }
                
            }
            else
            {
                var dialog1 = new MessageDialog("Ne postoji korisnik sa datom e-mail adresom!", "Neuspješno");
                await dialog1.ShowAsync();
            }
        }
       
    }
}
