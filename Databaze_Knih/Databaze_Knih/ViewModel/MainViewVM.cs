using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Databaze_Knih.View;

namespace Databaze_Knih.ViewModel
{
    class MainViewVM : Abstract.Property
    {
        public MainViewVM()
        {
            this.Prejdi = new Command(this.Prejdi_Execute);
        }

        public Command Prejdi { get; private set; }

        private void Prejdi_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainListView());
        }
    }
}
