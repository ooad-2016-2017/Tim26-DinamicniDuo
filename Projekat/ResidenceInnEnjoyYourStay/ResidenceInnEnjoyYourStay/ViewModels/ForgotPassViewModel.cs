using Microsoft.WindowsAzure.MobileServices;
using ResidenceInnEnjoyYourStay.Azure;
using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class ForgotPassViewModel : MainViewModelBase
    {
        private ICommand reset;
        private ICommand back;
        private ICommand pocetna;

        private String email;
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
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

        public ICommand ResetCommand
        {
            get
            {
                return reset ?? (reset = new CommandHandler(() => Reset(), true));
            }
        }
        IMobileServiceTable<RegistrovaniKorisnik> userTableObj = App.MobileService.GetTable<RegistrovaniKorisnik>();
        public async void Reset()
        {
            List<RegistrovaniKorisnik> table = await userTableObj.ToListAsync();
            RegistrovaniKorisnik r = new RegistrovaniKorisnik();
            bool ima = false;
            string emailAdd;
            for (int i = 0; i < table.Count; i++)
            {
                r = table[i];
                if (r.email == Email)
                {
                    ima = true;
                    emailAdd = Email;
                }
            }
            if (ima == true)
                ((Frame)Window.Current.Content).Navigate(typeof(ForgotPassword), Email);
            else if (ima == false)
            {
                MessageDialog msgDialog = new MessageDialog("Ne postoji data email adresa u bazi korisnika.");

                msgDialog.ShowAsync();
            }
        }
    }

}
