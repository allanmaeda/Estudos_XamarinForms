using Xamarin.Forms;

namespace XF_CarouselPage6
{
    public class MainPage : CarouselPage
    {
        public MainPage()
        {
            Children.Add(new Page1());
            Children.Add(new Page2());
            Children.Add(new Page3());
            Children.Add(new Page4());
        }

        protected override async void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (!(CurrentPage is Page4)) return;
            await DisplayAlert("Atenção", "A página 4 não está disponível", "Ok");
            CurrentPage = Children[2];
        }
    }
}
