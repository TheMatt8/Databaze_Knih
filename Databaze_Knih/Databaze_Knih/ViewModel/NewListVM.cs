using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Databaze_Knih.View;
using Databaze_Knih.Model;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Databaze_Knih.ViewModel
{
    class NewListVM
    {
        //Celé je de facto kopie MainListView pro "refresh"
        Kniha data;
        public NewListVM()
        {
            data = new Model.Kniha();
            this.Zpet = new Command(this.Zpet_Execute);
            this.Vse = new Command(this.Vse_Execute);
        }

        public string hledanyVyraz;
        public string HledanyVyraz
        {
            get { return hledanyVyraz; }
            set
            {
                hledanyVyraz = value;
                this.OnChangeProperty("HledanyVyraz");
            }
        }

        public Command Zpet { get; private set; }

        private void Zpet_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainView());
        }

        public Command Vse { get; private set; }

        private void Vse_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainListView());
        }

        private void OnChangeProperty(string nazevVlastnosti)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(nazevVlastnosti));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
