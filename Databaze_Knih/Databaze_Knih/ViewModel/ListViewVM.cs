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
    class ListViewVM
    {
        Kniha data;
        public ListViewVM()
        {
            data = new Model.Kniha();
            this.Zpet = new Command(this.Zpet_Execute);
            this.HA = new Command(this.HA_Execute);
            this.HN = new Command(this.HN_Execute);
        }

        //String pro hledání knihy
        public string hledanyVyraz = "";
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

        public Command HA { get; private set; }

        private async void HA_Execute()
        {
            App.List = await App.Databaze.HA(HledanyVyraz);
            App.Current.MainPage = new NavigationPage(new NewList());
        }
        public Command HN { get; private set; }

        private async void HN_Execute()
        {
            App.List = await App.Databaze.HN(HledanyVyraz);
            App.Current.MainPage = new NavigationPage(new NewList());
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
