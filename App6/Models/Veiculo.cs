using System;
using System.Collections.Generic;
using System.Text;

namespace App6.Models
{
    public class Veiculo
    {
        public const int FREIO_ABS = 800;
        public const int ARCONDICIONADO = 1000;
        public const int MP3_PLAYER = 500;

        public bool TemFreioAbs { get; set; }
        public bool TemArCondicionado { get; set; }
        public bool TemMp3Player { get; set; }

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: R$ {0}",
                    Preco
                    + (TemFreioAbs ? Veiculo.FREIO_ABS : 0)
                    + (TemArCondicionado ? Veiculo.ARCONDICIONADO : 0)
                    + (TemMp3Player ? Veiculo.MP3_PLAYER : 0)
                    );
            }
        }
}
}
