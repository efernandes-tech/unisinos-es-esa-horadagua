using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Horadagua.Pages.Hidratacoes
{
    public class HidratacoesNewPage : ContentPage
    {
        public HidratacoesNewPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Nova Hidratação" }
                }
            };
        }
    }
}