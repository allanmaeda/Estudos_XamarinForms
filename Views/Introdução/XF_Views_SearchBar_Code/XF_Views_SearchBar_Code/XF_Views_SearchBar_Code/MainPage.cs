using Xamarin.Forms;

namespace XF_Views_SearchBar_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var searchBar = new SearchBar
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                CancelButtonColor = Color.Black,
                Placeholder = "Digite o termo de busca",
                PlaceholderColor = Color.Green,
                FontSize = 25,
                FontAttributes = FontAttributes.Bold
            };

            searchBar.TextChanged += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("Texto que estava no elemento: " + args.OldTextValue);
                System.Diagnostics.Debug.WriteLine("Texto que está no elemento: " + args.NewTextValue);
            };

            searchBar.SearchButtonPressed += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("Texto no elemento: " + ((SearchBar) sender).Text);
            };


            Content = searchBar;
        }
    }
}
