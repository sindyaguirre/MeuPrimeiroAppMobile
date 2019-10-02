using App6.Models;
using App6.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel ViewModel { get; set; }
        public AgendamentoView(Veiculo veiculo)
        {

            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;

        }
        private void Button_Clicked(Object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
                string.Format(
                    @"Veiculo:{0}
                    Nome: {1}
                    Fone: {2}
                    E-mail: {3}
                    Data Agendamento: {4}
                    Hora Agendamento: {5}
                ",
                ViewModel.Agendamento.Veiculo.Nome,
                ViewModel.Agendamento.Nome,
                ViewModel.Agendamento.Fone,
                ViewModel.Agendamento.Email,
                ViewModel.Agendamento.DataAgendamento.ToString("dd/MM/yyyy"),
                ViewModel.Agendamento.HoraAgendamento
                ), "Ok");
        }

    }
}