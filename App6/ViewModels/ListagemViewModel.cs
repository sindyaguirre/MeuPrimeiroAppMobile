﻿using App6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App6.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;

        }
    }
}
