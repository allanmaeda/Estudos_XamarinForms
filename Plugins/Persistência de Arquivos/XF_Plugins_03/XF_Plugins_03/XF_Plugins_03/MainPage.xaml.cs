using System;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Extensions;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_03
{
	public partial class MainPage : ContentPage
	{
        public LocalRootFolder PastaRaiz { get; set; }

		public MainPage()
		{
			InitializeComponent();
            PastaRaiz = new LocalRootFolder();
		}

	    private async void ButtonFile_OnClicked(object sender, EventArgs e)
	    {
	        var arquivo = await PastaRaiz.CreateFileAsync("arquivo", CreationCollisionOption.ReplaceExisting);
            arquivo.WriteAllText("Exemplo de arquivo");

	        Editor.Text = $"Criação:         {arquivo.CreationTime}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Criação UTC:     {arquivo.CreationTimeUTC}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Acesso:          {arquivo.LastAccessTime}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Acesso UTC:      {arquivo.LastAccessTimeUTC}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Modificação:     {arquivo.LastWriteTime}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Modificação UTC: {arquivo.LastWriteTimeUTC}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Nome:            {arquivo.Name}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Caminho:         {arquivo.Path}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Tamanho:         {arquivo.Size}";
	    }

	    private async void ButtonFolder_OnClicked(object sender, EventArgs e)
	    {
	        var pasta = await PastaRaiz.CreateFolderAsync("pasta", CreationCollisionOption.ReplaceExisting);

	        Editor.Text = $"Criação:         {pasta.CreationTime}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Criação UTC:     {pasta.CreationTimeUTC}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Acesso:          {pasta.LastAccessTime}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Acesso UTC:      {pasta.LastAccessTimeUTC}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Modificação:     {pasta.LastWriteTime}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Modificação UTC: {pasta.LastWriteTimeUTC}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Nome:            {pasta.Name}{Environment.NewLine}{Environment.NewLine}";
	        Editor.Text += $"Caminho:         {pasta.Path}";
	    }
	}
}
