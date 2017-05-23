using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ResidenceInnEnjoyYourStay.Models
{
    public class SponzorisaniOglasi : BazniOglasi
    {
        private int cijenaSponzorstva;
        private int rokTrajanja;
        private DateTime pocetakSponzorisanja;

        public SponzorisaniOglasi(String lokacija, int cijena, String tip, int brojSoba, String pogodnosti, int brojOsoba, BitmapImage naslovna,int cijenaSponzo,int trajanje, DateTime pocetak) : base(lokacija, cijena, tip, brojSoba, pogodnosti, brojOsoba, naslovna)
        {
            this.cijenaSponzorstva = cijenaSponzo;
            this.rokTrajanja = trajanje;
            this.pocetakSponzorisanja = pocetak;
        }
        public int CijenaSponzorstva
        {
            get
            {
                return cijenaSponzorstva;
            }
            set
            {
                if (value != cijenaSponzorstva)
                {
                    cijenaSponzorstva = value;
                }
            }
        }
        public int RokTrajanja
        {
            get
            {
                return rokTrajanja;
            }
            set
            {
                if (value != rokTrajanja)
                {
                    rokTrajanja = value;
                }
            }
        }
        public DateTime PocetakSponzorisanja
        {
            get
            {
                return pocetakSponzorisanja;
            }
            set
            {
                if (value != pocetakSponzorisanja)
                {
                    pocetakSponzorisanja = value;
                }
            }
        }

    }
}
