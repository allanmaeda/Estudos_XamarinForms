using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XF_DataBinding3
{
    public partial class MinhaPage : ContentPage
    {
        public Model Model { get; }

        public MinhaPage()
        {
            InitializeComponent();

            Model = new Model
            {
                Nome = "Usuario exemplo",
                Idade = 20
            };

            BindingContext = Model;
        }

        private void ButtonInformacoes_OnClicked(object sender, EventArgs e)
        {
            Debug.WriteLine($"Model.Nome: {Model.Nome}");
            Debug.WriteLine($"Model.Idade: {Model.Idade}"); 
        }

        private void ButtonAleatorio_OnClicked(object sender, EventArgs e)
        {
            Model.Nome = "usuário teste";
            Model.Idade = new Random().Next(10, 50);
        }
    }
}
