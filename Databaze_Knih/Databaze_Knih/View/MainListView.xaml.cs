﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databaze_Knih.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Databaze_Knih.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainListView : ContentPage
	{
		public MainListView ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Knizky.ItemsSource = await App.Databaze.VratKnihy();

        }
    }
}