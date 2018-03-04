using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using SQLite;
using Xamarin.Forms;

namespace XF_Plugins_12
{
	public partial class App : Application
	{
        public SQLiteConnection Conexao { get; set; }

		public App ()
		{
		    var pasta = new LocalRootFolder();
		    var arquivo = pasta.CreateFile("banco.db", CreationCollisionOption.OpenIfExists);
		    Conexao = new SQLiteConnection(arquivo.Path);

		    Conexao.CreateTable<Model>();
			InitializeComponent();
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
