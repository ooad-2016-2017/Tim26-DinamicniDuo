using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD1.ResidenceInnBaza.Models
{
    public class RegistrovaniKorisnik : Osoba
    {
        private List<Oglasi> mojiOglasi;
        private List<Oglasi> favoriti;

        public RegistrovaniKorisnik()
        {

        }
        public RegistrovaniKorisnik(string im, string prez, DateTime datR, string us, string pass, string em) : base()
        {

        }
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
