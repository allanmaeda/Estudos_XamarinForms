using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using XF_Marvel.Models;

namespace XF_Marvel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            try
            {
                LayoutErro.IsVisible = false;
                ListView.IsVisible = false;
                CarregarDadosApi();
                LayoutErro.IsVisible = false;
                ListView.IsVisible = true;
            }
            catch (Exception ex)
            {
                LayoutErro.IsVisible = true;
                ListView.IsVisible = false;
            }
        }

        private void CarregarDadosApi()
        {
            IApiManager manager = null;

            Device.OnPlatform(
                Android: () => manager = DependencyService.Get<IApiManager>(),
                Default: () => manager = new ApiManager());

            var apireturn = "";

            var t1 = Task.Run(() =>
            {
                apireturn = manager.ObterPersonagens();
            });
            Task.WaitAll(t1);
            
            var result = JsonConvert.DeserializeObject(apireturn) as JObject;
            var data = result["data"]["results"];
            ListView.ItemsSource = new ObservableCollection<Character>(data.ToObject<List<Character>>());
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                LayoutErro.IsVisible = false;
                ListView.IsVisible = false;
                CarregarDadosApi();
                LayoutErro.IsVisible = false;
                ListView.IsVisible = true;
            }
            catch
            {
                LayoutErro.IsVisible = true;
                ListView.IsVisible = false;
            }
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (ListView.SelectedItem == null) return;
            var info = (Character)ListView.SelectedItem;
            ListView.SelectedItem = null;
            await Navigation.PushAsync(new DetailPage(info.Id));
        }


    }
}
