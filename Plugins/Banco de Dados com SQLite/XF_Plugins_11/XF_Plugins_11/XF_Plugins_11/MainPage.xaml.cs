using System;
using Xamarin.Forms;

namespace XF_Plugins_11
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    CarregarInformacoes();
		}

	    private void CarregarInformacoes()
	    {
	        var list = ((App)Application.Current).Conexao.Query<Model>("select * from informacoes");
	        ListView.ItemsSource = list;
	    }

	    private void ButtonAdicionar_OnClicked(object sender, EventArgs e)
	    {
	        ((App)Application.Current).Conexao.Execute($"insert into informacoes (info) values ('{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}')");
	        CarregarInformacoes();
	    }

	    private void MenuItemAtualizar_OnClicked(object sender, EventArgs e)
	    {
	        var mi = (MenuItem)sender;
	        var model = (Model)mi.CommandParameter;
	        var result = ((App) Application.Current).Conexao.Execute("update informacoes set info = ? where id = ?", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}", model.Id);
            CarregarInformacoes();
	    }

	    private void MenuItemApagar_OnClicked(object sender, EventArgs e)
	    {
	        var mi = (MenuItem)sender;
	        var model = (Model)mi.CommandParameter;
	        ((App) Application.Current).Conexao.Execute("delete from informacoes where id = ?", model.Id);
	        CarregarInformacoes();
	    }

	    private void ButtonApagarTudo_OnClicked(object sender, EventArgs e)
	    {
	        ((App)Application.Current).Conexao.Execute("delete from informacoes");
	        CarregarInformacoes();
	    }
	}
}
