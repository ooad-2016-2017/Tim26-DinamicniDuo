using Microsoft.WindowsAzure.MobileServices;
using ResidenceInnEnjoyYourStay.Azure;
using ResidenceInnEnjoyYourStay.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ResidenceInnEnjoyYourStay.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {
        public string text { get; set; }
        public Registracija()
        {
            this.InitializeComponent();
            this.DataContext = new RegisterViewModel();
        }
        Regex ImePrezime = new Regex("^[A-Z][a-z]{1,}$");
        Regex username = new Regex("^[a-zA-Z0-9]+([_ -]?[a-zA-Z0-9])*$");
        Regex password = new Regex("^[a-zA-Z0-9]+[- _ @ # $ %]?[a-zA-Z0-9]*$");
        Regex mail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
    }
}

