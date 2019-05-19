using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;


namespace Databaze_Knih.Model
{
    class Knihy
    {
        [Table("Knihy")]
        public class Kniha: INotifyPropertyChanged
        {
            private string _nazevKnihy;
            public string nazevKnihy
            {
                get { return _nazevKnihy; }
                set
                {
                    _nazevKnihy = value;
                    this.OnChangeProperty("Nazev");
                }
            }

            private string _autor;
            public string autor
            {
                get { return _autor; }
                set
                {
                    _autor = value;
                    this.OnChangeProperty("Autor");
                }
            }

            private string _info;
            public string Info
            {
                get { return _info; }
                set
                {
                    _info = value;
                    this.OnChangeProperty("Info");
                }
            }

            private string _isbn;
            public string isbn
            {
                get { return _isbn; }
                set
                {
                    _isbn = value;
                    this.OnChangeProperty("Isbn");
                }
            }

            private string _precteno;
            public string precteno
            {
                get { return _precteno; }
                set
                {
                    _precteno = value;
                    this.OnChangeProperty("Precteno");
                }
            }

            private string _chci;
            public string chci
            {
                get { return _chci; }
                set
                {
                    _chci = value;
                    this.OnChangeProperty("Chci");
                }
            }

            private string _obal;
            public string obal
            {
                get { return _obal; }
                set
                {
                    _obal = value;
                    this.OnChangeProperty("Obal");
                }
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
}
