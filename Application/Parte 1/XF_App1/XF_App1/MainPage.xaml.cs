using System;
using Xamarin.Forms;

namespace XF_App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SalvarValor_OnClick(object sender, EventArgs e)
        {
            if (!Application.Current.Properties.ContainsKey("valor"))
                Application.Current.Properties["valor"] = LabelExemplo.Text;
            else 
                Application.Current.Properties.Add("valor", LabelExemplo.Text);

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert("Atenção:", "Informação salva com sucesso!", "OK");
        }

        private async void CarregarValor_OnClick(object sender, EventArgs e)
        {
            if (!Application.Current.Properties.ContainsKey("valor"))
                return;
            var valor = Application.Current.Properties["valor"] as string;
            LabelExemplo.Text = valor;
            await DisplayAlert("Atenção:", "Informação carregada com sucesso!", "OK");
        }
    }
}
