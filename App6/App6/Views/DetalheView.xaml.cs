using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage    {
        private const int FREIO_ABS = 800;
        private const int ARCONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        bool temFreioABS;
        bool temArCondicionado;
        bool temMp3Player;


        public Veiculo Veiculo { get; set; }

        public string textoFreioABS{
            get {
                return string.Format("Freio ABS R$ {0}",FREIO_ABS);
                }
        }
        //contrutor do detalhe do veiculo
        public string textoArCondicionado
        {
            get
            {
                return string.Format("Ar condicionado R$ {0}", ARCONDICIONADO);
            }
        }

        public string textoMp3Player
        {
            get
            {
                return string.Format("MP3 Player R$ {0}", MP3_PLAYER);
            }
        }

        public bool TemFreioABS {

            get {
                return temFreioABS;
            }
            set {
                temFreioABS = value;

                OnPropertyChanged();//notifica quando o botao é alterado valor
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemArCondicionado{
            get{
                return temArCondicionado;
            }
            set{
                temArCondicionado = value;

                OnPropertyChanged();//notifica quando o botao é alterado valor
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemMp3Player{
            get
            {
                return temMp3Player;
            }
            set
            {
                temMp3Player = value;

                OnPropertyChanged();//notifica quando o botao é alterado valor
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal {
            get {

                return string.Format("Valor Total: R$ {0}", 
                    Veiculo.Preco
                    +(TemFreioABS ? FREIO_ABS : 0 )
                    + (TemArCondicionado ? ARCONDICIONADO: 0)
                    + (TemMp3Player ? MP3_PLAYER: 0)
                    ) ;

            }
        }

        public DetalheView(Veiculo veiculo) {
            InitializeComponent();
           
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void ButtonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}