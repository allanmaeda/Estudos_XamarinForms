using System;
using System.Linq;
using Xamarin.Forms;

namespace XF_Plugins_12
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
            var list = ((App) Application.Current).Conexao.Table<Model>().ToList();
            ListView.ItemsSource = list;
        }

        private void ButtonAdicionar_OnClicked(object sender, EventArgs e)
        {
            ((App) Application.Current).Conexao.Insert(new Model {Info = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}"});
            CarregarInformacoes();
        }

        private void MenuItemAtualizar_OnClicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var model = (Model)mi.CommandParameter;
            model.Info = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}";
            ((App) Application.Current).Conexao.Update(model);
            CarregarInformacoes();
        }

        private void MenuItemApagar_OnClicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var model = (Model)mi.CommandParameter;
            ((App) Application.Current).Conexao.Delete<Model>(model.Id);
            CarregarInformacoes();
        }

        private void ButtonApagarTudo_OnClicked(object sender, EventArgs e)
        {
            ((App) Application.Current).Conexao.DeleteAll<Model>();
            CarregarInformacoes();
        }
    }
}
