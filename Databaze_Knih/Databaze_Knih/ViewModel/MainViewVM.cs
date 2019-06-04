using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Databaze_Knih.View;
using System.ComponentModel;
using Databaze_Knih.Model;

namespace Databaze_Knih.ViewModel
{
    class MainViewVM
    {
        Model.Kniha data;
        public MainViewVM()
        {
            data = new Kniha();            
            this.Prejdi = new Command(this.Prejdi_Execute);
            this.Prejdi_Add = new Command(this.Prejdi_Add_Execute);
            this.Delete = new Command(this.Delete_Execute);
        }

        public Command Prejdi { get; private set; }

        private void Prejdi_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainListView());
        }

        public Command Delete { get; private set; }

        private void Delete_Execute()
        {
            App.Databaze.SmazKnihy();
        }

        public Command Prejdi_Add { get; private set; }

        private void Prejdi_Add_Execute()
        {
            App.Current.MainPage = new NavigationPage(new AddPage());
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
