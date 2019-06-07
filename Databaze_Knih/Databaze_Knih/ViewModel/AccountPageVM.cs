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
    class AccountPageVM
    {
        //Konstruktor
        public AccountPageVM()
        {
            this.Prejdi = new Command(this.Prejdi_Execute);
            this.Pridej = new Command(this.Add_Execute);
            this.Pridej1 = new Command(this.Add1_Execute);
        }

        //String pro hledání knihy k přídání do chci číst
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

        //String pro hledání knihy k přídání do přečteno
        public string hledanyVyraz1;
        public string HledanyVyraz1
        {
            get { return hledanyVyraz1; }
            set
            {
                hledanyVyraz1 = value;
                this.OnChangeProperty("HledanyVyraz1");
            }
        }

        //command na vyhledání a přidání
        public Command Pridej1 { get; private set; }

        private async void Add1_Execute()
        {
            await App.Cist.UlozKnihy(await App.Databaze.HNK(HledanyVyraz1));
            await App.Current.MainPage.DisplayAlert("Operace úspěšná", "Kniha byla přidána do databáze", "OK");
            App.Current.MainPage = new NavigationPage(new MainView());

        }

        //command na vyhledání a přidání
        public Command Pridej { get; private set; }

        private async void Add_Execute()
        {
            await App.Precteno.UlozKnihy(await App.Precteno.HNK(HledanyVyraz));
            await App.Current.MainPage.DisplayAlert("Operace úspěšná", "Kniha byla přidána do databáze", "OK");
            App.Current.MainPage = new NavigationPage(new MainView());

        }

        //Vrácení zpět
        public Command Prejdi { get; private set; }

        private void Prejdi_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainView());
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
