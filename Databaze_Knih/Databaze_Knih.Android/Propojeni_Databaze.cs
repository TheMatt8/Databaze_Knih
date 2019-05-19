using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Databaze_Knih.Model;
using System.IO;
using Databaze_Knih.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Propojeni_Databaze))]
namespace Databaze_Knih.Droid
{
    class Propojeni_Databaze : IDatabaze
    {
        public SQLiteConnection dkNapojeni()
        {
            var jmeno_databaze = "Knihy.db3";
            var cesta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), jmeno_databaze);
            return new SQLiteConnection(cesta);
        }
    }
}