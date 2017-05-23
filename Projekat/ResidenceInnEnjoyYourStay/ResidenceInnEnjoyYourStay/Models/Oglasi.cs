using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ResidenceInnEnjoyYourStay.Models
{
    public class Oglasi : BazniOglasi
    {
        public Oglasi(String lokacija, int cijena, String tip, int brojSoba, String pogodnosti, int brojOsoba, BitmapImage naslovna) : base(lokacija,cijena,tip,brojSoba,pogodnosti,brojOsoba,naslovna) { }
        public void Rezervisi()
        {

        }
        public Oglasi():base() { }
        public void Sponzorisi()
        {

        }
    }
}
