using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6.Views
{

    public class Veiculo{
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }

    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo{ Nome = "Azera V6", Preco=60000},
                new Veiculo{ Nome = "Fiesta 2.0", Preco=50000},
                new Veiculo{ Nome = "HB20 S", Preco=40000},
            };
            this.BindingContext = this;
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
