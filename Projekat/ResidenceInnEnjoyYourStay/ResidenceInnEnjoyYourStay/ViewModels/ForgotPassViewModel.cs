using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class ForgotPassViewModel
    {
        private ICommand reset;
        private ICommand back;
        private ICommand pocetna;
      
        public ICommand BackCommand
        {
            get
            {
                return back ?? (back = new CommandHandler(() => Nazad(), true));
            }
        }
        public void Nazad()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(LoginView), null);
        }

        public ICommand PocetnaCommand
        {
            get
            {
                return pocetna ?? (pocetna = new CommandHandler(() => Pocetna(), true));
            }
        }
        public void Pocetna()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(PocetnaStrana), null);
        }

        public ICommand ResetCommand
        {
            get
            {
                return reset ?? (reset = new CommandHandler(() => Reset(), true));
            }
        }
        
        public void Reset()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ForgotPassword), "A reset code was sent to your e-mail adress.");
        }
        
    }
}
