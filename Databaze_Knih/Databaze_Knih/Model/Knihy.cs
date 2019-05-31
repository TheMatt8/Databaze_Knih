using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;


namespace Databaze_Knih.Model
{
        public class Kniha
        {
            public int cislo = 0;
            
            //public Kniha(string nazevKnihy, string autor, string info, string isbn, string precteno, string chci, string obal, int id)
            //{
            //    this.nazevKnihy = nazevKnihy;
            //    this.autor = autor;
            //    this.info = info;
            //    this.isbn = isbn;
            //    this.precteno = precteno;
            //    this.chci = chci;
            //    this.obal = obal;
            //    this.id = id;
            //}

            protected string _nazevKnihy;
            public string nazevKnihy
            {
                get { return _nazevKnihy; }
                set
                {
                    _nazevKnihy = value;
                }
            }

            protected string _autor;
            public string autor
            {
                get { return _autor; }
                set
                {
                    _autor = value;
                }
            }

            protected string _info;
            public string info
            {
                get { return _info; }
                set
                {
                    _info = value;
                }
            }

            protected string _isbn;
            public string isbn
            {
                get { return _isbn; }
                set
                {
                    _isbn = value;
                }
            }

            protected string _precteno;
            public string precteno
            {
                get { return _precteno; }
                set
                {
                    _precteno = value;
                }
            }

            protected string _chci;
            public string chci
            {
                get { return _chci; }
                set
                {
                    _chci = value;
                }
            }

            protected string _obal;
            public string obal
            {
                get { return _obal; }
                set
                {
                    _obal = value;
                }
            }
            
            
            protected int _id;
            public int id
            {
                get { return _id; }
                set
                {
                    _id = value;
                }
            }

        }
    
}
