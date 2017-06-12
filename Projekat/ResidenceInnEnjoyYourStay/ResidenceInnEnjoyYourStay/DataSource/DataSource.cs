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
        private static List<RegistrovaniKorisnikModel> korisnici = new List<RegistrovaniKorisnikModel>() {
            new RegistrovaniKorisnikModel()
            {
                Ime="Nedim",
                Prezime="Djonlagic",
                Email="ndonlagic1@etf.unsa.ba",
                User="ned",
                Pass="1234",
                DatumRodjenja=new DateTime(1995,6,10),

            },
            new RegistrovaniKorisnikModel()
            {
                Ime="Adina",
                Prezime="Omerovic",
                Email="aomerovic2@etf.unsa.ba",
                User="dina",
                Pass="0000",
                DatumRodjenja=new DateTime(1996,2,16)
            }
        };
        public static IList<RegistrovaniKorisnikModel> DajSveKorisnike()
        {
            return korisnici;
        }
        public static RegistrovaniKorisnikModel ProvjeraKorisnika(String user, String sifra)
        {
            RegistrovaniKorisnikModel trazeni = new RegistrovaniKorisnikModel();
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
        private static List<OglasiModel> oglasi = new List<OglasiModel>() {
            new OglasiModel()
            {
                Lokacija="Otoka",
                Cijena=250,
                TipSmjestaja="Stan",
                BrojSoba=4,
                DodatnePogodnosti="namjesten stan, kablovska TV, internet",
                BrojOsoba=2,
                NaslovnaSlika=new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/soba2.jpg")),

            },
            new OglasiModel()
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
        public static IList<OglasiModel> DajsveOglase()
        {
            return oglasi;
        }
        public static IList<OglasiModel> DajOglase(String lokacija, int cijena)
        {
            return oglasi.FindAll(k => k.Lokacija == lokacija && k.Cijena == cijena);
        }
        #endregion

        #region sponzorisani oglasi
        private static List<SponzorisaniOglasi> sponzorisaniOglasi = new List<SponzorisaniOglasi>();

        public void sponzorisiOlgas(OglasiModel og,int cijena,int trajanje, DateTime pocetak)
        {
            SponzorisaniOglasi sponzi = new SponzorisaniOglasi(og.Naziv,og.Lokacija, og.Cijena, og.TipSmjestaja, og.BrojSoba, og.DodatnePogodnosti, og.BrojOsoba, og.NaslovnaSlika, cijena, trajanje, pocetak);
            sponzorisaniOglasi.Add(sponzi);
        }
        public static IList<SponzorisaniOglasi> DajSveSponzorisane()
        {
            return sponzorisaniOglasi;
        }
        #endregion

        #region rezervisani oglasi
        private static List<RezervisaniOglasi> rezervisaniOglasi = new List<RezervisaniOglasi>();
        public void rezervisiOglas(OglasiModel og,DateTime prijava,DateTime odjava)
        {
            RezervisaniOglasi reserved = new RezervisaniOglasi(og.Naziv, og.Lokacija, og.Cijena, og.TipSmjestaja, og.BrojSoba, og.DodatnePogodnosti, og.BrojOsoba, og.NaslovnaSlika, prijava, odjava);
            rezervisaniOglasi.Add(reserved);
        }
        public static IList<RezervisaniOglasi> DajSveRezervisane()
        {
            return rezervisaniOglasi;
        }
        #endregion
    }
}
