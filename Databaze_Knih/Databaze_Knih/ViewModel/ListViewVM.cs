using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Databaze_Knih.View;

namespace Databaze_Knih.ViewModel
{
    class ListViewVM : Abstract.Property
    {
        public ListViewVM()
        {
            this.Zpet = new Command(this.Zpet_Execute);
        }

        public Command Zpet { get; private set; }

        private void Zpet_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainView());
        }
    }
}
