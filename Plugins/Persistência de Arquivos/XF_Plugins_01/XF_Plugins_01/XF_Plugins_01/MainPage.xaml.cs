using System;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Extensions;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_01
{
	public partial class MainPage : ContentPage
	{
        private IFolder PastaRaiz { get; }
        
		public MainPage()
		{
			InitializeComponent();
		    PastaRaiz = new LocalRootFolder();
		}

	    private async void ButtonLoad_OnClicked(object sender, EventArgs e)
	    {
	        var nome = Entry.Text;

	        if (string.IsNullOrEmpty(nome))
	        {
	            await DisplayAlert("Atenção", "Digite um nome para o arquivo!", "Ok");
	            return;
	        }

	        var arquivoExiste = await PastaRaiz.CheckExistsAsync(nome);

	        if (arquivoExiste == ExistenceCheckResult.NotFound)
	        {
	            await DisplayAlert("Atenção", "Arquivo não existe!", "Ok");
	            Entry.Text = string.Empty;
	            return;
	        }

	        var arquivo = await PastaRaiz.GetFileAsync(nome);
	        Editor.Text = await arquivo.ReadAllTextAsync();
	    }

	    private async void ButtonSave_OnClicked(object sender, EventArgs e)
	    {
	        var nome = Entry.Text;
	        var conteudo = Editor.Text;

	        if (string.IsNullOrEmpty(nome))
	        {
	            await DisplayAlert("Atenção", "Digite um nome para o arquivo!", "Ok");
	            return;
	        }

	        var arquivoExiste = await PastaRaiz.CheckExistsAsync(nome);
	        var substituirArquivo = true;

	        if (arquivoExiste == ExistenceCheckResult.FileExists)
	            substituirArquivo = await DisplayAlert("Atenção", "Deseja substituir arquivo já existente?", "Sim", "Não");

	        if (!substituirArquivo) return;

	        var arquivo = await PastaRaiz.CreateFileAsync(nome, CreationCollisionOption.ReplaceExisting);
	        await arquivo.WriteAllTextAsync(conteudo);
	        Entry.Text = string.Empty;
	        Editor.Text = string.Empty;

	        await DisplayAlert("Atenção", "Arquivo criado com sucesso!", "Ok");
	    }

	    private async void ButtonErase_OnClicked(object sender, EventArgs e)
	    {
	        var nome = Entry.Text;

	        if (string.IsNullOrEmpty(nome))
	        {
	            await DisplayAlert("Atenção", "Digite um nome para o arquivo!", "Ok");
	            return;
	        }

	        var arquivoExiste = await PastaRaiz.CheckExistsAsync(nome);

	        if (arquivoExiste == ExistenceCheckResult.NotFound)
	        {
	            await DisplayAlert("Atenção", "Arquivo não existe!", "Ok");
	            Entry.Text = string.Empty;
	            return;
	        }

	        var apagar = await DisplayAlert("Atenção", "Deseja apagar este arquivo?", "Sim", "Não");

	        if (!apagar) return;
	        var arquivo = await PastaRaiz.GetFileAsync(nome);
	        await arquivo.DeleteAsync();
	        Entry.Text = string.Empty;
	        Editor.Text = string.Empty;
	    }
	}
}
