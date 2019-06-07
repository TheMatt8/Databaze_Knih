using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;


namespace Databaze_Knih.Model
{
        public class Kniha
        {
            protected string _nazevKnihy = "";
            public string NazevKnihy
            {
                get { return _nazevKnihy; }
                set
                {
                    _nazevKnihy = value;
                }
            }

            protected string _autor = "";
            public string Autor
            {
                get { return _autor; }
                set
                {
                    _autor = value;
                }
            }

            protected string _info = "";
            public string Info
            {
                get { return _info; }
                set
                {
                    _info = value;
                }
            }

            protected string _isbn = "";
            public string Isbn
            {
                get { return _isbn; }
                set
                {
                    _isbn = value;
                }
            }

            [PrimaryKey, AutoIncrement]
            public int Id
            {
                get; set;
            }
        }
    
}
