using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Aprofundado2.Models;

namespace XF_Aprofundado2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalPage : ContentPage
    {
        public FinalizarModel Model { get; set; }

        public FinalPage(IList<ElementoModel> models)
        {
            InitializeComponent();
            Model = new FinalizarModel
            {
                QuantElemento1 = $"Foram escolhidos {models.Count(x => x.Nome == "Elemento 1")} elementos 1",
                QuantElemento2 = $"Foram escolhidos {models.Count(x => x.Nome == "Elemento 2")} elementos 2",
                QuantElemento3 = $"Foram escolhidos {models.Count(x => x.Nome == "Elemento 3")} elementos 3"
            };
            BindingContext = Model;
        }

        private async void ButtonVoltar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}