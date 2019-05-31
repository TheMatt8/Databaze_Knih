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
            this.Prejdi = new Command(this.Prejdi_Execute);
            this.Prejdi_Add = new Command(this.Prejdi_Add_Execute);
        }

        public string nazevKnihy
        {
            get { return data.nazevKnihy; }
            set
            {
                data.nazevKnihy = value;
                this.OnChangeProperty("Nazev");
            }
        }

        public string autor
        {
            get { return data.autor; }
            set
            {
                data.autor = value;
                this.OnChangeProperty("Autor");
            }
        }

        public string Info
        {
            get { return data.info; }
            set
            {
                data.info = value;
                this.OnChangeProperty("Info");
            }
        }

        public string isbn
        {
            get { return data.isbn; }
            set
            {
                data.isbn = value;
                this.OnChangeProperty("Isbn");
            }
        }

        public string precteno
        {
            get { return data.precteno; }
            set
            {
                data.precteno = value;
                this.OnChangeProperty("Precteno");
            }
        }

        public string chci
        {
            get { return data.chci; }
            set
            {
                data.chci = value;
                this.OnChangeProperty("Chci");
            }
        }

        public string obal
        {
            get { return data.obal; }
            set
            {
                data.obal = value;
                this.OnChangeProperty("Obal");
            }
        }

        public int id
        {
            get { return data.id; }
            set
            {
                data.id = value;
                this.OnChangeProperty("ID");
            }
        }

        public Command Prejdi { get; private set; }

        private void Prejdi_Execute()
        {
            App.Current.MainPage = new NavigationPage(new MainListView());
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
