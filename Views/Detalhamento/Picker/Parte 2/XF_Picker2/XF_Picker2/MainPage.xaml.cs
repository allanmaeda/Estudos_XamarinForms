using Xamarin.Forms;

namespace XF_Picker2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Picker.Items.Add("Elemento 1");
            Picker.Items.Add("Elemento 2");
            Picker.Items.Add("Elemento 3");
            Picker.Items.Add("Elemento 4");
            Picker.Title = "Escolha um elemento";

            Picker.SelectedIndexChanged += async (sender, args) =>
            {
                await DisplayAlert("Atenção", (string) Picker.SelectedItem, "Ok");
            };
        }
    }
}
