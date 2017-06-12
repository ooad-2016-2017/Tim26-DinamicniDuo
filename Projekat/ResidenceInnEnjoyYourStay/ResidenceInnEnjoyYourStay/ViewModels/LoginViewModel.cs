using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ResidenceInnEnjoyYourStay.Azure;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using Windows.UI.Popups;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class LoginViewModel
    {
       
        private bool _isAuthenticated;
        public bool isAuthenticated
        {
            get { return _isAuthenticated; }
            set
            {
                if (value != _isAuthenticated)
                {
                    _isAuthenticated = value;
                    OnPropertyChanged("isAuthenticated");
                }
            }
        }

        private string _username;
        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("UserName");
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
            ((Frame)Window.Current.Content).Navigate(typeof(PregledObjavaAdmin), null);
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
            ((Frame)Window.Current.Content).Navigate(typeof(PregledObjavaAdmin), null);
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

        IMobileServiceTable<RegistrovaniKorisnik> userTableObj = App.MobileService.GetTable<RegistrovaniKorisnik>();

        //Data Source = tcp:residenceinnserver.database.windows.net,1433;Initial Catalog = ResidenceInnEnjoyYourStay; User ID = residenceinnadmin@residenceinnserver;Password=DinamicniDuo+
        public async void Login()
        {
            List<RegistrovaniKorisnik> table = await userTableObj.ToListAsync();

            bool imaUser = false;
            bool imaSifa = false;
            if (!String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(Password))
                isAuthenticated = true;
            if (UserName == "admin" && Password == "dinamicniduo")
                ((Frame)Window.Current.Content).Navigate(typeof(AdminPanel), "admin");
            else
            {
                RegistrovaniKorisnik r = new RegistrovaniKorisnik();
                for (int i = 0; i < table.Count; i++)
                {
                    r = table[i];
                    if (r.username == UserName)
                    {
                        imaUser = true;
                    }
                    if (r.password == Password)
                    {
                        imaSifa = true;
                    }

                }
                if (imaUser == true && imaSifa == true)
                    ((Frame)Window.Current.Content).Navigate(typeof(PregledObjavaAdmin), UserName);
                else if (imaUser == false)
                {
                    MessageDialog msgDialog = new MessageDialog("Ne postoji korisnik sa datim korisničkim imenom.");

                    msgDialog.ShowAsync();
                }
                else if (imaUser == true && imaSifa == false)
                {
                    MessageDialog msgDialog = new MessageDialog("Niste unijeli ispravnu sifru.");

                    msgDialog.ShowAsync();
                }
            }

        }

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
    }
}
 