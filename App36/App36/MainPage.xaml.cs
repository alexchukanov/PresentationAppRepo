﻿using System;
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
            await   Navigation.PushAsync(new WorkPage());
        }

        private void OnClick(object sender, EventArgs e)
        {

        }
    }
}
