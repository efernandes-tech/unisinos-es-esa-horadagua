using Horadagua.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horadagua.Paginas.Hidratacoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HidratacoesListPage : ContentPage
    {
        private HidratacaoDAL dalHidratacao = new HidratacaoDAL();

        public HidratacoesListPage()
        {
            InitializeComponent();
        }

        public async void OnRemoverClick(object sender, EventArgs e)
        {

        }
        public async void OnAlterarClick(object sender, EventArgs e)
        {

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lvHidratacoes.ItemsSource = dalHidratacao.GetAll();
        }
    }
}