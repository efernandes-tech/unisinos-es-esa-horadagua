using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Horadagua.Pages.Hidratacoes
{
    public class HidratacoesPage : TabbedPage
    {
        public HidratacoesPage()
        {
            Children.Add(new HidratacoesListPage()
            {
                Title = "Listagem",
                IconImageSource = "icone_list.png"
            });
            Children.Add(new HidratacoesNewPage()
            {
                Title = "Inserir Novo",
                IconImageSource = "icone_new.png"
            });
        }
    }
}