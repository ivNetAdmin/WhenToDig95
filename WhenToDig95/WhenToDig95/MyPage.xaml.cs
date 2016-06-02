
using System;
using Xamarin.Forms;

namespace WhenToDig95
{
    public partial class MyPage  : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Main;
        }

       
    }
}
