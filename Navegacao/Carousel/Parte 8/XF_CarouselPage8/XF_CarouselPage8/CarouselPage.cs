namespace XF_CarouselPage8
{
    public class CarouselPage : Xamarin.Forms.CarouselPage
    {
        public CarouselPage()
        {
            var mp = new MainPage();
            var mp3 = new MainPage3();

            Children.Add(mp);
            Children.Add(mp3);

            mp.PublicButton.Clicked += (sender, args) =>
            {
                if (Children.Count == 2)
                    Children.Insert(1, new MainPage2());
            };

            mp3.PublicButton.Clicked += (sender, args) =>
            {
                if (Children.Count == 3)
                    Children.RemoveAt(1);
            };
        }
    }
}
