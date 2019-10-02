using App6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6.Views
{

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();
            
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo) e.Item;
            //aqui ele navega para  aproxima pagina
            //Navigation empilha as paginas,ou seja a logica de pilha, e usando  ometdo assincrono
            //para que esta ação funcione deve ser alterado o arquvo de App.xaml.cs
            Navigation.PushAsync(new DetalheView(veiculo));

        }
    }
}
