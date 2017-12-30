using Xamarin.Forms;

namespace XF_MasterDetail1.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            Master = new Menu();
            Detail = new NavigationPage(new Detalhe());
        }
    }
}
