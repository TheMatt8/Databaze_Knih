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
        //Konstruktor
        public MainViewVM()
        {
            data = new Kniha();            
            this.Prejdi = new Command(this.Prejdi_Execute);
            this.Prejdi_Add = new Command(this.Prejdi_Add_Execute);
            this.Delete = new Command(this.Delete_Execute);
            this.Profil = new Command(this.Profil_Execute);
        }

        //Skok na list s databází
        public Command Prejdi { get; private set; }

        private void Prejdi_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainListView());
        }

        //Skok na profil s listy
        public Command Profil { get; private set; }

        private void Profil_Execute()
        {
            App.Current.MainPage = new NavigationPage(new AccountPage());
        }

        //Smazání celé databáze
        public Command Delete { get; private set; }

        private async void Delete_Execute()
        {
            App.Databaze.SmazKnihy();
            await App.Current.MainPage.DisplayAlert("Operace úspěšná", "Databáze je nyní krásně čistá", "OK");
        }

        //Skok na stránku pro přidání knihy
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
