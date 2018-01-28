using System;
using System.Collections.ObjectModel;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_07
{
	public partial class ListPage : ContentPage
	{
        public IFolder PastaAtual { get; }

	    private ObservableCollection<Model> ListaModels { get; set; }

	    public ListPage() : this(new LocalRootFolder()) { }

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
	        await PastaAtual.CreateFileAsync(Guid.NewGuid().ToString(), CreationCollisionOption.GenerateUniqueName);
	        CarregarConteudo();
	    }

	    private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        var model = e.SelectedItem as Model;
	        if (model.Tipo == "Pasta")
	        {
	            Navigation.PushAsync(new ListPage(PastaAtual.GetFolder(model.Nome)));
	        }
	    }
	}
}
