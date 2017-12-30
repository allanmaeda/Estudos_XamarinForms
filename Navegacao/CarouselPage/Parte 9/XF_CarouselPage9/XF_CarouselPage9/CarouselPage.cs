using System.Collections.Specialized;

namespace XF_CarouselPage9
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


        protected override async void OnPagesChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnPagesChanged(e);

            if (e.Action == NotifyCollectionChangedAction.Add)
                await DisplayAlert("Atenção", $"Index {e.NewStartingIndex} agora é uma página nova.", "Ok");
            else if (e.Action == NotifyCollectionChangedAction.Remove)
                await DisplayAlert("Atenção", $"Página que estava na posição {e.OldStartingIndex} foi apagada.", "Ok");
        }
    }
}
