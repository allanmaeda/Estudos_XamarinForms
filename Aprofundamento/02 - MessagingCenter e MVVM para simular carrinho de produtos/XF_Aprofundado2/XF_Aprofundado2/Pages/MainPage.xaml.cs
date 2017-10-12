using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using XF_Aprofundado2.Models;

namespace XF_Aprofundado2.Pages
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ElementoModel> ListaItens { get; }

        public MainPage()
        {
            InitializeComponent();
            ListaItens = new ObservableCollection<ElementoModel>();
            ListView.ItemsSource = ListaItens;

            MessagingCenter.Subscribe<AddPage>(this, "AddElemento1", p =>
            {
                ListaItens.Add(new ElementoModel
                {
                    Nome = "Elemento 1"
                });
            });
            MessagingCenter.Subscribe<AddPage>(this, "AddElemento2", p =>
            {
                ListaItens.Add(new ElementoModel
                {
                    Nome = "Elemento 2"
                });
            });
            MessagingCenter.Subscribe<AddPage>(this, "AddElemento3", p =>
            {
                ListaItens.Add(new ElementoModel
                {
                    Nome = "Elemento 3"
                });
            });
        }

        private void MenuItemApagar_OnClicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var model = (ElementoModel)mi.CommandParameter;
            ListaItens.Remove(model);
        }

        private async void ButtonAdicionar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddPage(), true);
        }

        private async void ButtonFinalizar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FinalPage(ListaItens.ToList()), true);
        }
    }
}
