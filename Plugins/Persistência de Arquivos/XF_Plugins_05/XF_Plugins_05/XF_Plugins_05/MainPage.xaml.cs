using System;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Extensions;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_05
{
	public partial class MainPage : ContentPage
	{
        public IFolder PastaRaiz { get; }

        public IFolder Pasta1 { get; }

        public IFolder Pasta2 { get; }

        public IFile ArquivoOriginal { get; set; }

        public IFile ArquivoNovo { get; set; }

		public MainPage()
		{
			InitializeComponent();
            PastaRaiz = new LocalRootFolder();
		    Pasta1 = PastaRaiz.CreateFolder("Pasta1", CreationCollisionOption.OpenIfExists);
		    Pasta2 = PastaRaiz.CreateFolder("Pasta2", CreationCollisionOption.OpenIfExists);
		}

	    private async void ButtonSave_OnClicked(object sender, EventArgs e)
	    {
	        var conteudo = Editor.Text;
	        ArquivoOriginal = await Pasta1.CreateFileAsync(Guid.NewGuid().ToString(), CreationCollisionOption.ReplaceExisting);
	        await ArquivoOriginal.WriteAllTextAsync(conteudo);
	        await DisplayAlert("Atenção", "Arquivo salvo com sucesso!", "Ok");
	        Editor.Text = string.Empty;
	    }

	    private void ButtonOpen_OnClicked(object sender, EventArgs e)
	    {
	        Editor.Text = ArquivoNovo.ReadAllText();
	    }

	    private async void ButtonMove_OnClicked(object sender, EventArgs e)
	    {
	        ArquivoNovo = await Pasta2.CreateFileAsync(Guid.NewGuid().ToString(), CreationCollisionOption.ReplaceExisting);
            await ArquivoOriginal.MoveAsync(ArquivoNovo);
	        await DisplayAlert("Atenção", "Arquivo movido com sucesso!", "Ok");
            if (!ArquivoOriginal.Exists)
                await DisplayAlert("Atenção", "Arquivo não existe mais no local original!", "Ok");
	    }
	}
}
