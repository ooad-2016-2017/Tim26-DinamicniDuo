using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
//using System.Data.SqlClient;

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
     /*   public void Konekcija()
        {
            SqlConnection conn = new SqlConnection("Server=13.85.86.7;Network Library=DBMSSOCN; Database=master;user id=residenceinnadmin;password=dinamicniduo+");
            SqlCommand cmd = new SqlCommand("SELECT * FROM RegistrovaniKorisnik WHERE user='" + UserName + "' AND password='" + Password + "'");
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();

        }*/
        public void Login()
        {
            if (!String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(Password))
                isAuthenticated = true;
            if(UserName == "admin" && Password == "dinamicniduo")
            ((Frame)Window.Current.Content).Navigate(typeof(AdminPanel), "admin");
          
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
 