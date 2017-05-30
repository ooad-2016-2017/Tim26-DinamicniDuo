using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ResidenceInnEnjoyYourStay.Models
{
   
    public class RegistrovaniKorisnik : Osoba
    {
       
        private int id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private BitmapImage profilnaSlika;

        private List<Oglasi> mojiOglasi;
       private List<Oglasi> favoriti;

        public RegistrovaniKorisnik(string im, string prez, DateTime datR, string us, string pass, string em, BitmapImage slika) : base(im,prez,datR,us,pass,em)
        {
            ProfilnaSlika = slika;
        }
        public RegistrovaniKorisnik():base() { }

        public BitmapImage ProfilnaSlika
        {
            get
            {
                return profilnaSlika;
            }
            set
            {
                profilnaSlika = value;
            }
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
