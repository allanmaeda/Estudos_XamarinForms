using System;
using System.Collections.ObjectModel;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Extensions;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_09
{
    public partial class ListPage : ContentPage
    {
        public IFolder PastaAtual { get; }

        private ObservableCollection<Model> ListaModels { get; set; }

        public ListPage() : this(new LocalRootFolder())
        {
        }

        public ListPage(IFolder pastaAtual)
        {
            InitializeComponent();
            PastaAtual = pastaAtual;
            CarregarConteudo();
        }

        private void CarregarConteudo()
        {
            ListaModels = new ObservableCollection<Model>();
            foreach (var pasta in PastaAtual.GetFolders())
            {
                ListaModels.Add(new Model
                {
                    Nome = pasta.Name,
                    Tipo = "Pasta"
                });
            }

            foreach (var arquivo in PastaAtual.GetFiles())
            {
                ListaModels.Add(new Model
                {
                    Nome = arquivo.Name,
                    Tipo = "Arquivo"
                });
            }

            ListView.ItemsSource = ListaModels;
        }

        private async void Button_CreateFolderOnClicked(object sender, EventArgs e)
        {
            await PastaAtual.CreateFolderAsync(Guid.NewGuid().ToString(), CreationCollisionOption.GenerateUniqueName);
            CarregarConteudo();
        }

        private async void Button_CreateFileOnClicked(object sender, EventArgs e)
        {
            var arquivo =
                await PastaAtual.CreateFileAsync(Guid.NewGuid().ToString(), CreationCollisionOption.GenerateUniqueName);
            await arquivo.WriteAllTextAsync($"Este arquivo foi criado em {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            CarregarConteudo();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var model = e.SelectedItem as Model;
                if (model.Tipo == "Pasta")
                {
                    Navigation.PushAsync(new ListPage(PastaAtual.GetFolder(model.Nome)));
                }

                if (model.Tipo == "Arquivo")
                {
                    Navigation.PushAsync(new DetailPage(PastaAtual.GetFile(model.Nome)));
                }

                ListView.SelectedItem = null;
            }
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var model = ((sender as MenuItem).CommandParameter) as Model;
            if (model.Tipo == "Pasta")
                await PastaAtual.GetFolder(model.Nome).DeleteAsync();
            if (model.Tipo == "Arquivo")
                await PastaAtual.GetFile(model.Nome).DeleteAsync();

            CarregarConteudo();
        }
    }
}
