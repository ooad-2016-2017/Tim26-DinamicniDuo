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
    public class Oglasi : BazniOglasi
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
