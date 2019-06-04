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

        public string Precteno
        {
            get { return data.Precteno; }
            set
            {
                data.Precteno = value;
                this.OnChangeProperty("Precteno");
            }
        }

        public string Chci
        {
            get { return data.Chci; }
            set
            {
                data.Chci = value;
                this.OnChangeProperty("Chci");
            }
        }

        public string Obal
        {
            get { return data.Obal; }
            set
            {
                data.Obal = value;
                this.OnChangeProperty("Obal");
            }
        }

        public int Id
        {
            get { return data.Id; }
            set
            {
                data.Id = value;
                this.OnChangeProperty("Id");
            }
        }

        public Command Pridej { get; private set; }

        private void Add_Execute()
        {
            App.Databaze.UlozKnihy(new Model.Kniha
            {
                NazevKnihy = NazevKnihy,
                Autor = Autor,
                Info = Info,
                Isbn = Isbn,
                Chci = "ne",
                Precteno = "ne",
                Obal = "",
                Id = data.cislo
            });
            data.cislo++;

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
