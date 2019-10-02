using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using App6.Models;

namespace App6.ViewModels
{
    class DetalheViewModel : INotifyPropertyChanged
    {
        public DetalheViewModel(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }

        public Veiculo Veiculo { get; set; }

        public string textoFreioABS
        {
            get
            {
                return string.Format("Freio ABS R$ {0}", Veiculo.FREIO_ABS);
            }
        }
        //contrutor do detalhe do veiculo
        public string textoArCondicionado
        {
            get
            {
                return string.Format("Ar condicionado R$ {0}", Veiculo.ARCONDICIONADO);
            }
        }

        public string textoMp3Player
        {
            get
            {
                return string.Format("MP3 Player R$ {0}", Veiculo.MP3_PLAYER);
            }
        }

        public bool TemFreioABS
        {

            get => Veiculo.TemFreioAbs;
            set
            {
                Veiculo.TemFreioAbs = value;

                OnPropertyChanged();//notifica quando o botao é alterado valor
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemArCondicionado
        {
            get => Veiculo.TemArCondicionado;
            set
            {
                Veiculo.TemArCondicionado = value;

                OnPropertyChanged();//notifica quando o botao é alterado valor
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemMp3Player
        {
            get => Veiculo.TemMp3Player;
            set
            {
                Veiculo.TemMp3Player = value;

                OnPropertyChanged();//notifica quando o botao é alterado valor
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;


            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name ="")
        {
            //?. é o nullo condicional, caso seja diferente de nullo ele faz
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
