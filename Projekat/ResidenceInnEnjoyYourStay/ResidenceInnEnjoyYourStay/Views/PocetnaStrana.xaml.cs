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
using ResidenceInnEnjoyYourStay.Models;
using Microsoft.WindowsAzure.MobileServices;
using ResidenceInnEnjoyYourStay.Azure;
using System.Collections.ObjectModel;
using System.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ResidenceInnEnjoyYourStay.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PregledObjavaAdmin : Page
    {
      
        public PregledObjavaAdmin()
        {
            this.InitializeComponent();
            this.DataContext = new PocetnaViewModel();
            mapa.Style = MapStyle.Aerial3DWithRoads;
            mapa.ZoomLevel = 20;
            //OglasiLista();
            Inicijalizuj();
            // this.DataContext = new GpsViewModel(mapa);

        }
        /* IMobileServiceTable<Oglasi> userTableObj = App.MobileService.GetTable<Oglasi>();
         public async void OglasiLista()
         {
          <ScrollViewer x:Name="Skrol" HorizontalAlignment="Left" Height="470" VerticalAlignment="Top" Width="228" Margin="541,100,0,0">

                 <ListView x:Name="listView" Height="470" Width="228">


             </ListView>

             Oglasi obj = new Oglasi();
             obj.naziv = "Hotel";
             obj.lokacija = "Otoka";
             obj.cijena = 300;
             obj.brojSoba = 2;
             obj.brojOsoba = 4;
             obj.tipSmjestaja = "Stan";
             await userTableObj.InsertAsync(obj);
             Oglasi obj1 = new Oglasi();
             obj1.lokacija = "Otoka";
             obj1.cijena = 300;
             obj1.brojSoba = 2;
             obj1.brojOsoba = 4;
             obj1.tipSmjestaja = "Stan";
             await userTableObj.InsertAsync(obj1);
             List<Oglasi> table = await userTableObj.ToListAsync();
             List<ListViewItem> items = new List<ListViewItem>();
             ListViewItem item1 = new ListViewItem();
             ListViewItem item2 = new ListViewItem();
             item1.Content = table[0].cijena;
             item2.Content = table[0].lokacija;
             items.Add(item1);
             items.Add(item2);
            // listView.Items.Add(items);
             //listView.Items.Add(items);
             List<ListViewItem> items1 = new List<ListViewItem>();
             ListViewItem item11 = new ListViewItem();
             ListViewItem item21 = new ListViewItem();
             item11.Content = table[1].cijena;
             item21.Content = table[1].lokacija;
             items1.Add(item11);
             items1.Add(item21);
             listView.ItemsSource = items1;

             //textBlock7.Text = table[0].cijena.ToString();
             // textBlock6.Text = table[0].lokacija;

         }
        /* public List<OglasiModel> ListaOglasa { get; set; }
         public void Oglasii()
         {
             ListaOglasa = new List<OglasiModel>
            {
                new OglasiModel
                {
                    Lokacija = "Sarajevo",
                    Cijena = 300,
                    BrojOsoba = 4,
                    BrojSoba = 2,
                    DodatnePogodnosti = "balkon",
                    TipSmjestaja = "stan"
                },
                new OglasiModel
                {
                    Lokacija = "Sarajevo",
                    Cijena = 300,
                    BrojOsoba = 4,
                    BrojSoba = 2,
                    DodatnePogodnosti = "balkon",
                    TipSmjestaja = "stan"
                },
            };

         }*/
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameters = e.Parameter as string;

            if (parameters != null)
            {
                korisnik.Text = parameters;
            }
            if(korisnik.Text != "")
            {
                button1.Visibility = Visibility.Collapsed;
                Odjava.Visibility = Visibility.Visible;
            }
            
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
