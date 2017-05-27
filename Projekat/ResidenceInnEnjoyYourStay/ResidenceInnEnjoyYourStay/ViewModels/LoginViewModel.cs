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
    public class LoginViewModel
    {
        private ICommand login;
        private ICommand register;
        private ICommand forgot;
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
            ((Frame)Window.Current.Content).Navigate(typeof(PocetnaStrana), null);
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

        public ICommand ForgotPasswordCommand
        {
            get
            {
                return forgot ?? (forgot = new CommandHandler(() => ForgotPassword(), true));
            }
        }
        public void ForgotPassword()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ForgotPassword), null);
        }

        public ICommand RegisterCommand
        {
            get
            {
                return register ?? (register = new CommandHandler(() => Register(), true));
            }
        }
        public void Register()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(Registracija), null);
        }

        public ICommand LoginCommand
        {
            get
            {
                return login ?? (login = new CommandHandler(() => Login(), true));
            }
        }

        public void Login()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(PocetnaStrana), null);
        }
    }
}
