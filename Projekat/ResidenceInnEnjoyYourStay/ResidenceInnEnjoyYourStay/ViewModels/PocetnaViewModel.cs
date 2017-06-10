using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Data;

namespace ResidenceInnEnjoyYourStay.ViewModels
{
    public class PocetnaViewModel
    {
        private ICommand login;

        public ICommand LoginCommand
        {
            get
            {
                return login ?? (login = new CommandHandler(() => Login(), true));
            }
        }
        public void Login()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(LoginView), null);
        }
        
        

    }
}
