using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceInnEnyojYourStay.Models
{
    public abstract class BazniOglasi : MainViewModelBase
    {
        private String lokacija;
        private int cijena;
        private String tipSmjestaja;
        private int brojSoba;
        private String dodatnePogodnosti;
        private int brojOsoba;

        public BazniOglasi()
        {

        }
        public String Lokacija
        {
            get
            {
                return lokacija;
            }
            set
            {
                if (value != lokacija)
                {
                    lokacija = value;
                    OnPropertyChanged("Lokacija");

                }
            }
        }
        public int Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if (value != cijena)
                {
                    cijena = value;
                    OnPropertyChanged("Cijena");
                }
            }
        }
        public String TipSmjestaja
        {
            get
            {
                return tipSmjestaja;
            }
            set
            {
                if (value != tipSmjestaja)
                {
                    tipSmjestaja = value;
                    OnPropertyChanged("TipSmjestaja");
                }
            }
        }
        public int BrojSoba
        {
            get
            {
                return brojSoba;
            }
            set
            {
                if (value != brojSoba)
                {
                    brojSoba = value;
                    OnPropertyChanged("BrojSoba");
                }
            }
        }
        public String DodatnePogodnosti
        {
            get
            {
                return dodatnePogodnosti;
            }
            set
            {
                if (value != dodatnePogodnosti)
                {
                    dodatnePogodnosti = value;
                    OnPropertyChanged("DodatnePogodnosti");
                }
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
                if (value != brojOsoba)
                {
                    brojOsoba = value;
                    OnPropertyChanged("BrojOsoba");
                }
            }
        }
    }
}
