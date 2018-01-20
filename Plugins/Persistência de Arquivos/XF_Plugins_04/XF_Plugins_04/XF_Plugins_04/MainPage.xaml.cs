using System;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_04
{
	public partial class MainPage : ContentPage
	{
	    private IFolder PastaRaiz { get; }

		public MainPage()
		{
			InitializeComponent();
		    PastaRaiz = new LocalRootFolder();
		}

	    private async void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
	    {
	        var textoDigitado = ((SearchBar) sender).Text;
            
	        var arquivosEncontrados = PastaRaiz.GetFiles(textoDigitado, FolderSearchOption.AllFolders);
	        await DisplayAlert("Atenção", $"Foram encontrados {arquivosEncontrados.Count} arquivos com este padrão de nome", "Ok");
	    }


	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        var nomeDoArquivo = Guid.NewGuid().ToString();
	        await PastaRaiz.CreateFileAsync(nomeDoArquivo, CreationCollisionOption.GenerateUniqueName);
	        await DisplayAlert("Atenção", $"Arquivo {nomeDoArquivo} gerado com sucesso", "Ok");
	    }
	}
}
