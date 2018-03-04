using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using SQLite;
using Xamarin.Forms;

namespace XF_Plugins_10
{
	public partial class App : Application
	{
	    public SQLiteConnection Conexao { get; private set; }

		public App ()
		{
		    var pasta = new LocalRootFolder();
		    var arquivo = pasta.CreateFile("banco.db", CreationCollisionOption.OpenIfExists);
		    Conexao = new SQLiteConnection(arquivo.Path);
		    Conexao.Execute("create table if not exists informacoes (id integer primary key autoincrement, info text)");

			InitializeComponent();
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            
		}

		protected override void OnSleep ()
		{

		}

		protected override void OnResume ()
		{

		}
	}
}
