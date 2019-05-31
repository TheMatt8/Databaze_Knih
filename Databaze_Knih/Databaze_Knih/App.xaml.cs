using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Databaze_Knih.View;
using Databaze_Knih.Model;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Databaze_Knih
{
    public partial class App : Application
    {
        static KnihyDatabaze databaze;

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
