﻿using LosGatos.Pages;
using Xamarin.Forms;

namespace LosGatos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage() ){
                BarBackgroundColor = Color.Transparent
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}