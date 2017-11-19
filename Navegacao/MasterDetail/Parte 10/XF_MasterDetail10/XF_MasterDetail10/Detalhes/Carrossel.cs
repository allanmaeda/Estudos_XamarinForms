using Xamarin.Forms;

namespace XF_MasterDetail10.Detalhes
{
    public class Carrossel : CarouselPage
    {
        public Carrossel()
        {
            Children.Add(new PageCarousel1());
            Children.Add(new PageCarousel2());
            Children.Add(new PageCarousel3());
        }
    }
}
