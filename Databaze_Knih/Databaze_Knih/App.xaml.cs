using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Databaze_Knih.View;
using Databaze_Knih.Model;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Databaze_Knih
{
    public partial class App : Application
    {
        static KnihyDatabaze databaze;
        static KnihyDatabaze cist;
        static KnihyDatabaze precteno;
        static List<Kniha> list;

        public App()
        {
            InitializeComponent();
            MainPage = new MainView();
        }

        public static KnihyDatabaze Databaze
        {
            get
            {
                if (databaze == null)
                {
                    databaze = new KnihyDatabaze(DependencyService.Get<IDatabaze>().ZiskejCestu("Knihy.db3"));
                }
                return databaze;
            }
            set
            {
                databaze = value;
            }
        }

        public static KnihyDatabaze Cist
        {
            get
            {
                if (cist == null)
                {
                    cist = new KnihyDatabaze(DependencyService.Get<IDatabaze>().ZiskejCestu("Cist.db3"));
                }
                return cist;
            }
            set
            {
                cist = value;
            }
        }

        public static KnihyDatabaze Precteno
        {
            get
            {
                if (precteno == null)
                {
                    precteno = new KnihyDatabaze(DependencyService.Get<IDatabaze>().ZiskejCestu("Precteno.db3"));
                }
                return precteno;
            }
            set
            {
                precteno = value;
            }
        }

        public static List<Kniha> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
