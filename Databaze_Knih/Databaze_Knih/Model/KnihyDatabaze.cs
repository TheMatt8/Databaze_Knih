using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;
using Databaze_Knih.Model;
using System.Threading.Tasks;

namespace Databaze_Knih.Model
{
    public class KnihyDatabaze
    {
        readonly SQLiteAsyncConnection databaze;

        public KnihyDatabaze (string cesta)
        {
            databaze = new SQLiteAsyncConnection(cesta);
            databaze.CreateTableAsync<Kniha>().Wait();
        }

        public Task<List<Kniha>> VratKnihy()
        {
            return databaze.Table<Kniha>().ToListAsync();
        }

        public Task<Kniha> VratKnihu(int id_hledany)
        {
            return databaze.Table<Kniha>().Where(i => i.id == id_hledany).FirstOrDefaultAsync();
        }

        public Task<int> UlozKnihy(Kniha kniha)
        {
            if (kniha.id == 0)
            {
                return databaze.InsertAsync(kniha);
            }
            else { return databaze.UpdateAsync(kniha); }
        }

        public Task<int> SmazKnihy(Kniha kniha)
        {
            return databaze.DeleteAsync(kniha);
        }

    }
    
}
