using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ResidenceInnEnjoyYourStay.Models
{
    public class RezervisaniOglasi : BazniOglasi
    {
        private DateTime datumPrijave;
        private DateTime datumOdjave;
        public RezervisaniOglasi(String naziv, String lokacija, int cijena, String Tip, int brojSoba, String pogodnosti, int brojOsoba, BitmapImage naslovna,DateTime prijava,DateTime odjava) : base(naziv,lokacija, cijena, Tip, brojSoba, pogodnosti, brojOsoba, naslovna)
        {
            this.datumPrijave = prijava;
            this.datumOdjave = odjava;
        }

        public DateTime DatumPrijave
        {
            get
            {
                return datumPrijave;
            }
            set
            {
                if (value != datumPrijave)
                {
                    datumPrijave = value;
                }
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
                if (value != datumOdjave)
                {
                    datumOdjave = value;
                }
            }
        }
    }
}
