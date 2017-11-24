using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_Picker4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Elemento> Elementos;

        public MainPage()
        {
            InitializeComponent();
            Elementos = new ObservableCollection<Elemento>();
            Picker.ItemsSource = Elementos;

            MessagingCenter.Subscribe<AddEditPage, Elemento>(this, "NovoElemento", (page, elemento) =>
            {
                Elementos.Add(elemento);
            });
        }

        private async void ButtonAdd_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddEditPage());
        }
    }
}
