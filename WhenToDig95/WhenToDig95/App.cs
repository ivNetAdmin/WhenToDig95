﻿using WhenToDig95.ViewModel;
using Xamarin.Forms;

namespace WhenToDig95
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(GetMainPage());
        }
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        public static Page GetMainPage()
        {
            return new MyPage();
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