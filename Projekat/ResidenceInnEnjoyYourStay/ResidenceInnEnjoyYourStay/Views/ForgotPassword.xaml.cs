using ResidenceInnEnjoyYourStay.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class ForgotPassword : Page
    {
        public string text { get; set; }
        public ForgotPassword()
        {
            this.InitializeComponent();
            this.DataContext = new ForgotPassViewModel();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
             text = e.Parameter as string;
            if (text != null)
            {
                textBlock4.Text = text;
                //Do your stuff
            }
        }


    }
}
