using Horadagua.Paginas.Hidratacoes;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horadagua.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        Uri uri;

        public MenuPage()
        {
            InitializeComponent();
        }

        private async void MinhaHidratacaoOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HidratacoesPage());
        }

        private async void ParticiparPesquisaOnClicked(object sender, EventArgs args)
        {
            try
            {
                uri = new Uri("https://bit.ly/horadagua");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // Não foi possivel acessar a uri
                await DisplayAlert("Erro : ", ex.Message, "Ok");
            }
        }
    }
}