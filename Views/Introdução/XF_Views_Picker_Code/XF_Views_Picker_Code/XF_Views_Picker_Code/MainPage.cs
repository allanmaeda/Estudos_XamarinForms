using Xamarin.Forms;

namespace XF_Views_Picker_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var picker = new Picker
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill
            };

            picker.Items.Add("Opção 1");
            picker.Items.Add("Opção 2");
            picker.Items.Add("Opção 3");

            picker.SelectedIndexChanged += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine($"Índice escolhido do picker: {((Picker)sender).SelectedIndex}");
                System.Diagnostics.Debug.WriteLine($"Elemento escolhido do picker: {((Picker)sender).Items[((Picker)sender).SelectedIndex]}");
            };

            Content = picker;
        }
    }
}
