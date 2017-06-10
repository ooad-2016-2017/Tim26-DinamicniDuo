using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ResidenceInnEnjoyYourStay.DataSrource;
using Windows.UI.Xaml.Controls.Maps;
using ResidenceInnEnjoyYourStay.ViewModels;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ResidenceInnEnjoyYourStay.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PocetnaStrana : Page
    {
      
        public PocetnaStrana()
        {
            this.InitializeComponent();
            this.DataContext = new PocetnaViewModel();
            mapa.Style = MapStyle.Aerial3DWithRoads;
            mapa.ZoomLevel = 20;
            Inicijalizuj();
            // this.DataContext = new GpsViewModel(mapa);

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameters = e.Parameter as string;
            korisnik.Text = parameters;
            
        }
        
        public void Inicijalizuj()
        {
            double lat = 0;
            double lonng = 0;
            Random random = new Random();
            double randomNumber;
           
            for (int i = 0; i < 50; i++)
            {
                randomNumber = random.NextDouble() * (-0.01);
                lat = 43.860259 + randomNumber;
                randomNumber = random.NextDouble() * 0.1;
                lonng = 18.437282 - randomNumber;
                Geopoint point1= new Geopoint(new BasicGeoposition() { Latitude = lat, Longitude = lonng });
                MapIcon myPoint1 = new MapIcon { Location = point1, NormalizedAnchorPoint = new Point(0.5, 1.0), Title = "Position " + i, ZIndex = 0 };
                mapa.MapElements.Add(myPoint1);
            }
            Geopoint point = new Geopoint(new BasicGeoposition() { Latitude = 43.848098, Longitude = 18.375717 });
            MapIcon myPoint = new MapIcon { Location = point, NormalizedAnchorPoint = new Point(0.5, 1.0), Title = "My position", ZIndex = 0 };
            mapa.MapElements.Add(myPoint);
            mapa.Center = point;
        }
    }
}
