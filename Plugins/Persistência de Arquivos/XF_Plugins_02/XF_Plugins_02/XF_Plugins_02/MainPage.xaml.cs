using System;
using System.Collections.Generic;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_02
{
	public partial class MainPage : ContentPage
	{
        public IFolder PastaRaiz { get; }
        public List<Model> Itens { get; }
        

		public MainPage()
		{
			InitializeComponent();
		    PastaRaiz = new LocalRootFolder();
            Itens = new List<Model>();
		}

	    protected override async void OnAppearing()
	    {
	        base.OnAppearing();

	        // varrendo todos os arquivos e pastas e apagando todo o conteudo
	        foreach (var arquivo in await PastaRaiz.GetFilesAsync())
	            await arquivo.DeleteAsync();
	        foreach (var pasta in await PastaRaiz.GetFoldersAsync())
	            await pasta.DeleteAsync();

	        // criando arquivos e pastas aleatoriamente
	        var rand = new Random();

	        var numeroMaximoDeArquivos = rand.Next(11, 15);

	        for (var i = 1; i <= numeroMaximoDeArquivos; i++)
	            await PastaRaiz.CreateFileAsync(i + "-arq", CreationCollisionOption.GenerateUniqueName);

	        var numeroMaximoDePastas = rand.Next(11, 15);

	        for (var i = 1; i <= numeroMaximoDePastas; i++)
	            await PastaRaiz.CreateFolderAsync(i + "-dir", CreationCollisionOption.GenerateUniqueName);

	        foreach (var arquivo in await PastaRaiz.GetFilesAsync())
	            Itens.Add(new Model
	            {
                    Titulo = "Arquivo",
                    Nome = arquivo.Name
	            });

            foreach (var pasta in await PastaRaiz.GetFoldersAsync())
                Itens.Add(new Model
                {
                    Titulo = "Pasta",
                    Nome = pasta.Name
                });

            ListView.ItemsSource = Itens;

	    }
	}
}
