using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer_Page : ContentPage
    {
        public Timer_Page()
        {
            InitializeComponent();
        }

        private void timer_btn_Clicked(object sender, EventArgs e)
        {

        }

        private async void tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}