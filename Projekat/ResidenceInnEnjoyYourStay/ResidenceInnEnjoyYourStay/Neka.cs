using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ResidenceInnEnjoyYourStay
{
    public class Neka
    {
        public Neka()
        {
            Uri neki = new Uri("ms-appx://ResidenceInnEnjoyYourStay/Assets/StoreLogo.png");
            slika = new BitmapImage(neki);
            slika.DecodePixelHeight = 10;
            slika.DecodePixelWidth = 10;
        }
        public string text { get; set; } = "LOl jhasdjhasdjhasjh ashdjh ajhsdasjhdauis duiasdui dajhsdhas hdasjh dasjhd jhajhd ha jkadjasdjkasdjkasdj jasdjk jkjka as";
        public BitmapImage slika { get; set; }
        public string text2 { get; set; } = "WTF";
    }
}
