using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AquaVeilMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void BtSubmit_OnClicked(object sender, EventArgs e)
        {
            string tmp = "Drink!";
            eHeight.Text = tmp;
            eWidth.Text = tmp;
            Thread.CurrentThread.Abort();
            await Navigation.PopAsync();
            await Navigation.PushAsync(new MainPage());
            
        }
    }
}