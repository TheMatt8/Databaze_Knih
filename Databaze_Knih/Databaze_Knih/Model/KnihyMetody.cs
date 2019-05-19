using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;
using Databaze_Knih.Model;

namespace Databaze_Knih.Model
{
    class KnihyMetody
    {
        public class KnihyData
        {
            private SQLiteConnection databaze;
            public ObservableCollection<Kniha> Knihy { get; set; }
            public static object zamek = new object();

            public KnihyData()
            {
                databaze = DependencyService.Get<IDatabaze>().dkNapojeni();
                databaze.CreateTable<Kniha>();
                this.Knihy = new ObservableCollection<Kniha>(databaze.Table<Kniha>());
            }

            public void PridatKnihu()
            {
                this.Knihy.Add(new Kniha { nazevKnihy = "", autor = "", Info = "", isbn = "", obal = "", chci = "", precteno = "" });
            }

            /*public IEnumerable<Kniha> Filtr( nejaka polozka)
            {
                lock(zamek)
                {
                    var query = from book in databaze.Table<Kniha>() where book.něco = pllozka select book;
                    return query.AsEnumerable();
                }
                //return databaze.Query<Kniha>("SELECT * FROM něco").AsEnumerable();
                //return databaze.Table<Kniha>().FirstOrDefault(Kniha => Kniha.ID == ID)
            }*/

            public int UlozitKnihu(Kniha knihakpridani)
            {
                lock(zamek)
                {
                    if (knihakpridani.id != 0)
                    {
                        databaze.Update(knihakpridani);
                        return knihakpridani.id;
                    }
                    else
                    {
                        databaze.Insert(knihakpridani);
                        return knihakpridani.id;
                    }
                }
            }

            public void UlozitVsechnyKnihu()
            {
                lock (zamek)
                {
                    foreach (var knihakpridani in this.Knihy)
                    {
                        if (knihakpridani.id != 0)
                        {
                            databaze.Update(knihakpridani);
                        }
                        else
                        {
                            databaze.Insert(knihakpridani);
                        }
                    }
                }
            }
        }
    }
}
