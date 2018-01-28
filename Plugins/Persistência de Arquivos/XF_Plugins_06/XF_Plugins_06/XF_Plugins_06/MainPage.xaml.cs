using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using Xamarin.Forms;

namespace XF_Plugins_06
{
	public partial class MainPage : ContentPage
	{
	    public IFolder PastaRaiz { get; }
        public IFile Arquivo { get; }
        
		public MainPage()
		{
			InitializeComponent();
		    PastaRaiz = new LocalRootFolder();
		    Arquivo = PastaRaiz.CreateFile(Guid.NewGuid().ToString(), CreationCollisionOption.ReplaceExisting);
		}

	    private async void ButtonSave_OnClicked(object sender, EventArgs e)
	    {
	        var model = new Model
	        {
	            Propriedade1 = Label1.Text,
	            Propriedade2 = Label2.Text
	        };

	        var bf = new BinaryFormatter();
	        var ms = new MemoryStream();
	        bf.Serialize(ms, model);

	        await Arquivo.WriteAllBytesAsync(ms.ToArray());
	        Label1.Text = string.Empty;
	        Label2.Text = string.Empty;
	    }


	    private async void ButtonLoad_OnClicked(object sender, EventArgs e)
	    {
	        var conteudo = await Arquivo.ReadAllBytesAsync();

	        var memStream = new MemoryStream();
	        var binForm = new BinaryFormatter();
	        memStream.Write(conteudo, 0, conteudo.Length);
	        memStream.Seek(0, SeekOrigin.Begin);

	        var model = (Model) binForm.Deserialize(memStream);

	        Label1.Text = model.Propriedade1;
	        Label2.Text = model.Propriedade2;
	    }
	}
}
