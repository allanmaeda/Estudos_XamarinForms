using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_ListView12
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Model> Lista { get; }

        public MainPage()
        {
            InitializeComponent();
            Lista = new ObservableCollection<Model>();

            for (var i = 1; i <= 30; i++)
            {
                Lista.Add(new Model
                {
                    Informacao = $"Elemento {i:D2}"
                });
            }

            MyListView.ItemsSource = Lista;
        }

        private void MenuItemMais_OnClicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var model = (Model)mi.CommandParameter;
            Label.Text = $"Celula com texto {model.Informacao} foi escolhida";
        }

        private void MenuItemApagar_OnClicked(object sender, EventArgs e)
        {
            var mi = (MenuItem) sender;
            var model = (Model)mi.CommandParameter;
            Lista.Remove(model);
        }
    }
}
