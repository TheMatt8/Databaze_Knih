using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using Databaze_Knih.View;
using Databaze_Knih.Model;

namespace Databaze_Knih.ViewModel
{
    class AddPageVM : INotifyPropertyChanged
    {
        Model.Kniha data;

        public AddPageVM()
        {
            data = new Model.Kniha();
            this.Pridej = new Command(this.Add_Execute);
            this.Prejdi = new Command(this.Prejdi_Execute);
        }

        public string NazevKnihy
        {
            get { return data.NazevKnihy; }
            set
            {
                data.NazevKnihy = value;
                this.OnChangeProperty("Nazev");
            }
        }

        public string Autor
        {
            get { return data.Autor; }
            set
            {
                data.Autor = value;
                this.OnChangeProperty("Autor");
            }
        }

        public string Info
        {
            get { return data.Info; }
            set
            {
                data.Info = value;
                this.OnChangeProperty("Info");
            }
        }

        public string Isbn
        {
            get { return data.Isbn; }
            set
            {
                data.Isbn = value;
                this.OnChangeProperty("Isbn");
            }
        }

        public Command Pridej { get; private set; }

        private async void Add_Execute()
        {
            await App.Databaze.UlozKnihy(new Model.Kniha
            {
                NazevKnihy = NazevKnihy,
                Autor = Autor,
                Info = Info,
                Isbn = Isbn
            });
            await App.Current.MainPage.DisplayAlert("Operace úspěšná", "Kniha byla přidána do databáze", "OK");
            App.Current.MainPage = new NavigationPage(new MainView());

        }
        

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
