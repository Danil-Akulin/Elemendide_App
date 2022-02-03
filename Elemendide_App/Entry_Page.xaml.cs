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
    public partial class Entry_Page : ContentPage
    {
        public Entry_Page()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Editor ed = new Editor
            {
                Placeholder = "Sisesta siis teksti",
                BackgroundColor = Color.AntiqueWhite,
                TextColor = Color.DarkGreen,
                //VerticalOptions=new LayoutOptions(LayoutAlignment.Fill)
            };
            st.Children.Add(ed);
            Button tagasi = new Button
            {
                Text = "Tagasi"
            };
            tagasi.Clicked += Tagasi_Clicked;
            st.BackgroundColor = Color.WhiteSmoke;
            Content = st;

        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}