using System;
using Xamarin.Forms;

namespace XF_Plugins_10
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
            var list = ((App)Application.Current).Conexao.Query<Model>("select info from informacoes");
            ListView.ItemsSource = list;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var query = $"insert into informacoes (info) values ('{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}')";
            ((App)Application.Current).Conexao.Execute(query);
            CarregarInformacoes();
        }
    }
}
