using Microsoft.WindowsAzure.MobileServices;
using ResidenceInnEnjoyYourStay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceInnEnjoyYourStay.Azure
{
    public class RegistrovaniKorisnik
    {
        public string id
        {
            get;
            set;
        }
        public string ime
        {
            get;
            set;
        }
        public string prezime
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public string username
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public DateTime datumRodjenja
        {
            get;
            set;
        }
        IMobileServiceTable<RegistrovaniKorisnik> userTableObj = App.MobileService.GetTable<RegistrovaniKorisnik>();
        public bool Pretrazi()
        {
            RegistrovaniKorisnikModel rk = new RegistrovaniKorisnikModel(ime, prezime, datumRodjenja, username, password, email);
           

            return false;
        }
    }
}



