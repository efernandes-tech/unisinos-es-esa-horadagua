using Horadagua.Pages.Hidratacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Horadagua.Pages
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu de opções";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Button()
                    {
                        Text = "Minha Hidratação",
                        ImageSource = "icon_hydration.png",
                        Command = new Command(() => Navigation.PushAsync(new HidratacoesPage()))
                    }
                }
            };
        }
    }
}