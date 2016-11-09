using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XF_DataBinding5
{
    public partial class MainPage : ContentPage
    {
        public ViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ViewModel = new ViewModel();
            BindingContext = ViewModel;
        }

        private void ImprimirInformacoes(object sender, EventArgs e)
        {
            Debug.WriteLine($"Nome: {ViewModel.Nome}, Sobrenome: {ViewModel.Sobrenome}");    
        }

        private void ForcarInformacaoViaBackend(object sender, EventArgs e)
        {
            ViewModel.Nome = "Nome teste";
            ViewModel.Sobrenome = "Sobrenome teste";
        }
    }
}
