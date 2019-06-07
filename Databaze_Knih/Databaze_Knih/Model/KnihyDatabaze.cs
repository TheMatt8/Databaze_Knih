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
        //metody databáze + její konstruktor
        readonly SQLiteAsyncConnection databaze;

        public KnihyDatabaze(string cesta)
        {
            databaze = new SQLiteAsyncConnection(cesta);
            databaze.CreateTableAsync<Kniha>().Wait();
        }

        public Task<List<Kniha>> VratKnihy()
        {
            return databaze.Table<Kniha>().ToListAsync();
        }

        public Task<int> UlozKnihy(Kniha kniha)
        {
            if (kniha.Id == 0)
            {
                return databaze.InsertAsync(kniha);
            }
            else { return databaze.UpdateAsync(kniha); }
        }

        public Task<int> SmazKnihu(Kniha kniha)
        {
            return databaze.DeleteAsync(kniha);
        }

        public void SmazKnihy()
        {
            databaze.DropTableAsync<Kniha>().Wait();
            databaze.CreateTableAsync<Kniha>().Wait();
        }

        public  Task<List<Kniha>> HA(string retezec)
        {
            return databaze.Table<Kniha>().Where(i => i.Autor == retezec).ToListAsync();
        }

        public Task<List<Kniha>> HN(string retezec)
        {
            return databaze.Table<Kniha>().Where(i => i.NazevKnihy == retezec).ToListAsync();
        }

        public Task<Kniha> HNK(string retezec)
        {
            return databaze.Table<Kniha>().Where(i => i.NazevKnihy == retezec).FirstOrDefaultAsync();
        }
    }
    
}
