﻿
using ResidenceInnEnjoyYourStay.Models;
using ResidenceInnEnjoyYourStay.Pomocne;
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
        ICommand registracija
        {
            get; set;
        }
        ICommand zabSifra
        {
            get; set;
        }
       
   
        public String AdminIme { get; set; }
        public String AdminSifra { get; set; }

        public List<RegistrovaniKorisnikModel> ListaKorisnika = new List<RegistrovaniKorisnikModel>();
     
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
            
            ListaKorisnika = new List<RegistrovaniKorisnikModel>();
       
            Login = new RelayCommand<object>(registrujAdmina, potvrdi);
     

        }

        public ICommand RegistrujSe
        {
            get
            {
                INS.Navigate(typeof(Register));
                return registracija;
            }
            set
            {
                registracija = value;
            }

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