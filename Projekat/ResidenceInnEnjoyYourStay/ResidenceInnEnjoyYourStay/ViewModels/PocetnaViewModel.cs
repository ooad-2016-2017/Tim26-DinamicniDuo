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
using System.Data;
using ResidenceInnEnjoyYourStay.Azure;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class PocetnaViewModel: MainViewModelBase
    {
        private String naziv;
        private String lokacija;
        private int brojOsoba;
        private double maxCijena;
        private DateTime datumPrijave;
        private DateTime datumOdjave;
        private ICommand search;
        private ICommand login;
        private ICommand logout;

        public ICommand LoginCommand
        {
            get
            {
                return login ?? (login = new CommandHandler(() => Login(), true));
            }
        }
        public void Login()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(LoginView), null);
        }
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
        public String Lokacija
        {
            get
            {
                return lokacija;
            }
            set
            {
                lokacija = value;
                OnPropertyChanged("Lokacija");
            }
        }
        public int BrojOsoba
        {
            get
            {
                return brojOsoba;
            }
            set
            {
                brojOsoba = value;
                OnPropertyChanged("BrojOsoba");
            }
        }
        public double MaxCijena
        {
            get
            {
                return maxCijena;
            }
            set
            {
                maxCijena = value;
                OnPropertyChanged("MaxCijena");
            }
        }
        public DateTime DatumPrijave
        {
            get
            {
                return datumPrijave;
            }
            set
            {
                datumPrijave = value;
                OnPropertyChanged("DatumPrijave");
            }
        }
        public DateTime DatumOdjave
        {
            get
            {
                return datumOdjave;
            }
            set
            {
                datumOdjave = value;
                OnPropertyChanged("DatumOdjave");
            }
        }
        public String Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
                OnPropertyChanged("Naziv");
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return search ?? (search = new CommandHandler(() => Search(), true));
            }
        }
        IMobileServiceTable<Oglasi> userTableObj = App.MobileService.GetTable<Oglasi>();
        public async void Search()
        {
            List<Oglasi> table = await userTableObj.ToListAsync();
            List<Oglasi> oglasi = new List<Oglasi>();
            Oglasi pomocna = new Oglasi();
            for(int i = 0; i < table.Count; i++)
            {
                pomocna = table[i];
                if(pomocna.lokacija == Lokacija && pomocna.cijena >= MaxCijena && pomocna.brojOsoba >= BrojOsoba)
                {
                    oglasi.Add(pomocna);
                }
            }
            ((Frame)Window.Current.Content).Navigate(typeof(pregledObjava), oglasi);


        }
        private ICommand trazi;
        public ICommand TraziCommand
        {
            get
            {
                return trazi ?? (trazi = new CommandHandler(() => Trazi(), true));
            }
        }
       // IMobileServiceTable<Oglasi> userTableObj = App.MobileService.GetTable<Oglasi>();
        public async void Trazi()
        {
            List<Oglasi> table = await userTableObj.ToListAsync();
            List<Oglasi> oglasi = new List<Oglasi>();
            bool ima = false;
            Oglasi pomocna = new Oglasi();
            for (int i = 0; i < table.Count; i++)
            {
                pomocna = table[i];
                if (pomocna.naziv == Naziv)
                {
                    oglasi.Add(pomocna);
                    ima = true;
                }
            }
            if(ima == true)
             ((Frame)Window.Current.Content).Navigate(typeof(pregledObjava), oglasi);
            else if(ima == false)
            {
                MessageDialog msgDialog = new MessageDialog("Ne postoji hotel sa datim nazivom.");

                msgDialog.ShowAsync();
            }


        }



    }
}
