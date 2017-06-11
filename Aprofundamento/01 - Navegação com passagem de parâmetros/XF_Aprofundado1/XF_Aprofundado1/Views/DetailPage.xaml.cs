using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Aprofundado1.Models;

namespace XF_Aprofundado1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(IEnumerable<InformacaoDetalhe> detalhes)
        {
            InitializeComponent();
            ListView.ItemsSource = new ObservableCollection<InformacaoDetalhe>(detalhes);
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}