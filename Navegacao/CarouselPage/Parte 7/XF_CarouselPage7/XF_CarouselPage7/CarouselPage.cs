namespace XF_CarouselPage7
{
    public class CarouselPage : Xamarin.Forms.CarouselPage
    {
        public CarouselPage()
        {
            var mainPage = new MainPage();
            Children.Add(mainPage);

            mainPage.PublicButton.Clicked += async (sender, args) =>
            {
                if (string.IsNullOrEmpty(mainPage.PublicEntry.Text))
                {
                    await DisplayAlert("Atenção", "Não é possível adicionar uma nova página!", "Ok");
                    return;
                }
                Children.Add(new NewPage(mainPage.PublicEntry.Text));
                mainPage.PublicEntry.Text = string.Empty;
            };
        }
    }
}
