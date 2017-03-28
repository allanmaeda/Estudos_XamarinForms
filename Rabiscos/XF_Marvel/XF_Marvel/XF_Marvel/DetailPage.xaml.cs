using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Marvel.Models;

namespace XF_Marvel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public int IdPersonagem { get; }

        public DetailPage(int id)
        {
            InitializeComponent();
            IdPersonagem = id;

            try
            {
                CarregarDadosApi();
            }
            catch
            {
                LayoutErro.IsVisible = true;
                Layout.IsVisible = false;
            }
        }

        private void CarregarDadosApi()
        {
            var listOfComics = new List<ComicItem>();

            IApiManager manager = null;
            Device.OnPlatform(
                Android: () => manager = DependencyService.Get<IApiManager>(),
                Default: () => manager = new ApiManager()
                );

            var result1 = "";

            var t1 = Task.Run(() =>
            {
                result1 = manager.ObterDetalhePersonagem(IdPersonagem);
            });
            Task.WaitAll(t1);


            var result = JsonConvert.DeserializeObject(result1) as JObject;
            var charDetail = result["data"]["results"].First();
            Nome.Text = charDetail["name"].ToObject<string>();
            Descricao.Text = charDetail["description"].ToObject<string>();
            Imagem.Source = ImageSource.FromUri(new Uri(charDetail["thumbnail"]["path"].ToObject<string>() + "." + charDetail["thumbnail"]["extension"].ToObject<string>()));

            foreach (var comic in charDetail["comics"]["items"])
            {
                var t = Task.Run(() =>
                {
                    result1 = manager.ObterDetalheComic(comic["resourceURI"].ToObject<string>());
                });
                Task.WaitAll(t);

                var resultComic = JsonConvert.DeserializeObject(result1) as JObject;
                var comicDetail = resultComic["data"]["results"].First()["thumbnail"];
                var image = comicDetail["path"].ToObject<string>() + "." + comicDetail["extension"].ToObject<string>();
                listOfComics.Add(new ComicItem { Thumbnail = ImageSource.FromUri(new Uri(image)), Nome = comic["name"].ToObject<string>() });
            }

            ListView.ItemsSource = listOfComics;
            ListView.IsVisible = true;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                LayoutErro.IsVisible = false;
                Layout.IsVisible = false;
                CarregarDadosApi();
                LayoutErro.IsVisible = false;
                Layout.IsVisible = true;
            }
            catch
            {
                LayoutErro.IsVisible = true;
                Layout.IsVisible = false;
            }
        }
    }
}
