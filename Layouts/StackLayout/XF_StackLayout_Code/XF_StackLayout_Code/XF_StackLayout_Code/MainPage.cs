using Xamarin.Forms;

namespace XF_StackLayout_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label { Text = "Olá mundo!" },
                    new Button { Text = "Botão na page!" }
                }
            };
        }
    }
}
