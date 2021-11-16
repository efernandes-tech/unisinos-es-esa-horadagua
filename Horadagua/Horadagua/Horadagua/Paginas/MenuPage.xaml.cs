using Horadagua.Paginas.Hidratacoes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horadagua.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void HidratacoesOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HidratacoesPage());
        }
    }
}