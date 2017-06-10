using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using ResidenceInnEnjoyYourStay.Azure;
using Windows.UI.Xaml.Input;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class RegisterViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _password2;
        public string Password2
        {
            get { return _password2; }
            set
            {
                _password2 = value;
                OnPropertyChanged("Password2");
            }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        Regex ImePrezime = new Regex("^[A-Z][a-z]{1,}$");
        Regex username = new Regex("^[a-zA-Z0-9]+([_ -]?[a-zA-Z0-9])*$");
        Regex password = new Regex("^[a-zA-Z0-9]+[- _ @ # $ %]?[a-zA-Z0-9]*$");
        Regex mail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");


        #region INotifyPropertyChanged Methods

        public void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private ICommand register;
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

        public ICommand RegisterCommand
        {
            get
            {
                return register ?? (register = new CommandHandler(() => Register(), true));
            }
        }
        IMobileServiceTable<RegistrovaniKorisnik> userTableObj = App.MobileService.GetTable<RegistrovaniKorisnik>();
        private void Register()
        {
            try
            {
                RegistrovaniKorisnik obj = new RegistrovaniKorisnik();
                obj.ime = Name;
                obj.prezime = Surname;
                obj.email = Email;
                obj.password = Password;
                obj.username = Username;
                obj.datumRodjenja = new DateTime(1995,1,1);
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
        public void Register2()
        {

            if (!ImePrezime.IsMatch(Name))
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Unesite ispravno ime");
            else if (!ImePrezime.IsMatch(Surname))
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Unesite ispravno prezime");
            else if (!username.IsMatch(Username))
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Niste unijeli ispravan format korisnickog imena");
            else if (!password.IsMatch(Password))
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Niste unijeli ispravan format sifre");
            else if (!mail.IsMatch(Email))
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Niste unijeli ispravan e-mail");
            else if (Password != Password2)
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Šifre se ne podudaraju");
            else if (ImePrezime.IsMatch(Name) && ImePrezime.IsMatch(Surname) && username.IsMatch(Username) && password.IsMatch(Password) && mail.IsMatch(Email))
                ((Frame)Window.Current.Content).Navigate(typeof(Registracija), "Uspješno ste registrovani");


        }
        
    }
}
 