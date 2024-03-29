﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new FormularioCadastro());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
          await Navigation.PushModalAsync(new ListaProdutos());
        }
    }
}