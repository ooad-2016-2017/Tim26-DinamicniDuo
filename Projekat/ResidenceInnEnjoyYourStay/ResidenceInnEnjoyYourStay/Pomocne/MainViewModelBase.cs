using ResidenceInnEnjoyYourStay.Pomocne;
using ResidenceInnEnjoyYourStay.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ResidenceInnEnyojYourStay
{
    public abstract class MainViewModelBase : INotifyPropertyChanged // for notifying that particular class has changed
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private ICommand login;
        public ICommand LoginCommand
        {
            get
            {
                return login ?? (login = new CommandHandler(() => Login(), true));
            }
        }
        INavigationService INS { get; set; }
        public void Login()
        {
            INS.Navigate(typeof(PocetnaStrana), null);
        }

    }
}
