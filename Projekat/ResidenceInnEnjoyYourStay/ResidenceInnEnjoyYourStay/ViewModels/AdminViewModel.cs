
using ResidenceInnEnjoyYourStay.Models;
using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class AdminViewModel
    {
        private ICommand back;
        private ICommand pocetna;
        private ICommand logout;
        private ICommand korisnici;
        private ICommand objave;

        public ICommand LogoutCommand
        {
            get
            {
                return logout ?? (logout = new CommandHandler(() => Logout(), true));
            }
        }
        public void Logout()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(PregledObjavaAdmin), null);
        }
        public ICommand PregledObjava
        {
            get
            {
                return objave ?? (objave = new CommandHandler(() => Objava(), true));
            }
        }
        public void Objava()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(PregledObjavaAdmin), null);
        }
        public ICommand PregledKorisnika
        {
            get
            {
                return korisnici ?? (korisnici = new CommandHandler(() => Korisnici(), true));
            }
        }
        public void Korisnici()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(pregledNalogaAdmin), null);
        }
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
            ((Frame)Window.Current.Content).Navigate(typeof(PregledObjavaAdmin), null);
        }




    }
}