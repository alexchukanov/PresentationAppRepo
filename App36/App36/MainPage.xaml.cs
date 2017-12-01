using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App36
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async  void OnTapped(object sender, EventArgs e)
        {           
            await ((Image)sender).FadeTo(0.8);          
            await Navigation.PushAsync(new WorkPage());
            await ((Image)sender).FadeTo(1);
        }

        private void OnClick(object sender, EventArgs e)
        {

        }

        private void Image_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}
