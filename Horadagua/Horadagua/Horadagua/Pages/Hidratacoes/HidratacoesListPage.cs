using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Horadagua.Pages.Hidratacoes
{
    public class HidratacoesListPage : ContentPage
    {
        public HidratacoesListPage()
        {
            Content = GetHidratacoes();
        }

        private ListView GetHidratacoes()
        {
            var hidratacoes = new ListView();

            hidratacoes.ItemsSource = new string[]
            {
                "10:00 - 500ml (1 garrafinha)",
                "12:00 - 500ml (1 garrafinha)",
                "14:00 - 500ml (1 garrafinha)",
                "18:00 - 500ml (1 garrafinha)"
            };

            return hidratacoes;
        }
    }
}