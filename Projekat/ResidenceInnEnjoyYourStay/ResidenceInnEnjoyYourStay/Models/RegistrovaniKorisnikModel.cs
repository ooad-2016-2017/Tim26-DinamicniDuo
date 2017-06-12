using ResidenceInnEnjoyYourStay.Pomocne;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;


namespace ResidenceInnEnjoyYourStay.Models
{
   
    public class RegistrovaniKorisnikModel : MainViewModelBase
    {
       
        private int id { get; set; }
        [Key]
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

        private String ime;
        private String prezime;
        private String email;
        private String user;
        private String password;
        private DateTime datumRodjenja;

        public String Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (value != ime)
                {
                    ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }
        public String Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (value != prezime)
                {
                    prezime = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public String User
        {
            get
            {
                return user;
            }
            set
            {
                if (value != user)
                {
                    user = value;
                    OnPropertyChanged("User");
                }
            }
        }
        public String Pass
        {
            get
            {
                return password;
            }
            set
            {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged("Pass");
                }
            }
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                if (value != datumRodjenja)
                {
                    datumRodjenja = value;
                    OnPropertyChanged("DatumRodjenja");
                }
            }
        }
        private BitmapImage profilnaSlika;

        private List<OglasiModel> mojiOglasi;
       private List<OglasiModel> favoriti;

        public RegistrovaniKorisnikModel(string im, string prez, DateTime datR, string us, string pass, string em, BitmapImage slika)
        {
            Ime = im;
            Prezime = prez;
            DatumRodjenja = datR;
            User = us;
            Pass = pass;
            Email = em;
            ProfilnaSlika = slika;
        }
        public RegistrovaniKorisnikModel(string im, string prez, DateTime datR, string us, string pass, string em)
        {
            Ime = im;
            Prezime = prez;
            DatumRodjenja = datR;
            User = us;
            Pass = pass;
            Email = em;
           
        }
        public RegistrovaniKorisnikModel() { }

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
       public List<OglasiModel> MojiOglasi
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
        public List<OglasiModel> Favoriti
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
