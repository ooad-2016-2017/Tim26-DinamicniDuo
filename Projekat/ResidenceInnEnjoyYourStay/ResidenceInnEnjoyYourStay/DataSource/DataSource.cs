using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResidenceInnEnjoyYourStay.Models;

namespace ResidenceInnEnjoyYourStay.DataSrource
{
    public class DataSourceResidenceInnEnjoyYourStay
    {
        #region registrovaniKorisnici
        private static List<RegistrovaniKorisnik> korisnici = new List<RegistrovaniKorisnik>() {
            new RegistrovaniKorisnik()
            {
                Ime="Nedim",
                Prezime="Djonlagic",
                Email="ndonlagic1@etf.unsa.ba",
                User="ned",
                Pass="1234",
                DatumRodjenja=new DateTime(1995,6,10),

            },
            new RegistrovaniKorisnik()
            {
                Ime="Adina",
                Prezime="Omerovic",
                Email="aomerovic2@etf.unsa.ba",
                User="dina",
                Pass="0000",
                DatumRodjenja=new DateTime(1996,2,16)
            }
        };
        public static IList<RegistrovaniKorisnik> DajSveKorisnike()
        {
            return korisnici;
        }
        public static RegistrovaniKorisnik ProvjeraKorisnika(String user, String sifra)
        {
            RegistrovaniKorisnik trazeni = new RegistrovaniKorisnik();
            foreach(var i in DajSveKorisnike())
            {
                if (i.User == user && i.Pass == sifra)
                {

                    trazeni = i;
                    break;
                }
            }
            return trazeni;
        }
        #endregion

        #region Oglasi
        private static List<Oglasi> oglasi = new List<Oglasi>() {
            new Oglasi()
            {
                Lokacija="Otoka",
                Cijena=250,
                TipSmjestaja="Stan",
                BrojSoba=4,
                DodatnePogodnosti="namjesten stan, kablovska TV, internet",
                BrojOsoba=2,
                NaslovnaSlika=new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/soba2.jpg")),

            },
            new Oglasi()
            {
                Lokacija="Dobrinja",
                Cijena=120,
                TipSmjestaja="Soba",
                BrojSoba=2,
                DodatnePogodnosti="TV",
                BrojOsoba=1,
                NaslovnaSlika =new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/soba2.jpg"))
            }
        };
        public static IList<Oglasi> DajsveOglase()
        {
            return oglasi;
        }
        public static IList<Oglasi> DajOglase(String lokacija, int cijena)
        {
            return oglasi.FindAll(k => k.Lokacija == lokacija && k.Cijena == cijena);
        }
        #endregion

        #region sponzorisani oglasi
        private static List<SponzorisaniOglasi> sponzorisaniOglasi = new List<SponzorisaniOglasi>();

        public void sponzorisiOlgas(Oglasi og,int cijena,int trajanje, DateTime pocetak)
        {
            SponzorisaniOglasi sponzi = new SponzorisaniOglasi(og.Lokacija, og.Cijena, og.TipSmjestaja, og.BrojSoba, og.DodatnePogodnosti, og.BrojOsoba, og.NaslovnaSlika, cijena, trajanje, pocetak);
            sponzorisaniOglasi.Add(sponzi);
        }
        public static IList<SponzorisaniOglasi> DajSveSponzorisane()
        {
            return sponzorisaniOglasi;
        }
        #endregion

        #region rezervisani oglasi
        private static List<RezervisaniOglasi> rezervisaniOglasi = new List<RezervisaniOglasi>();
        public void rezervisiOglas(Oglasi og,DateTime prijava,DateTime odjava)
        {
            RezervisaniOglasi reserved = new RezervisaniOglasi(og.Lokacija, og.Cijena, og.TipSmjestaja, og.BrojSoba, og.DodatnePogodnosti, og.BrojOsoba, og.NaslovnaSlika, prijava, odjava);
            rezervisaniOglasi.Add(reserved);
        }
        public static IList<RezervisaniOglasi> DajSveRezervisane()
        {
            return rezervisaniOglasi;
        }
        #endregion
    }
}
