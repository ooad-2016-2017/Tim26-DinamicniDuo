
using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnyojYourStay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class AdminViewModel
    {
       
        INavigationService INS { get; set; }
        ICommand login
        {
            get; set;
        }
       
       
   
        public String AdminIme { get; set; }
        public String AdminSifra { get; set; }

        public List<RegistrovaniKorisnik> ListaKorisnika = new List<RegistrovaniKorisnik>();
     
        public ICommand Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

 
        public AdminViewModel()
        {
            
            ListaKorisnika = new List<RegistrovaniKorisnik>();
       
            Login = new RelayCommand<object>(registrujAdmina, potvrdi);
     

        }
        
        public bool potvrdi(Object o)
        {
            if (AdminIme == "admin" && AdminSifra == "dinamicniduo")
            {
                return true;
            }
            return false;
        }

        public void registrujAdmina(Object o)
        {
           
        }

        public bool boolDodaj(Object o)
        {
            return true;
        }

    

    }
}