using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceInnEnjoyYourStay.Models
{
    public class RegistrovaniKorisnik : Osoba
    {
        private List<Oglasi> mojiOglasi;
        private List<Oglasi> favoriti;

        public RegistrovaniKorisnik(string im, string prez, DateTime datR, string us, string pass, string em) : base(im,prez,datR,us,pass,em)
        {

        }
        public RegistrovaniKorisnik():base() { }

        public List<Oglasi> MojiOglasi
        {
            get
            {
                return mojiOglasi;
            }
            set
            {
                if (value != mojiOglasi)
                {
                    mojiOglasi = value;
                }
            }
        }
        public List<Oglasi> Favoriti
        {
            get
            {
                return favoriti;
            }
            set
            {
                if (value != favoriti)
                {
                    favoriti = value;
                }
            }
        }
    }
}
