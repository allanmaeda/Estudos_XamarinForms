using Xamarin.Forms;

namespace XF_MasterDetail6.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public ContentPage ContentPage { get; }

        public NavigationPage NavigationPage { get; }

        public TabbedPage TabbedPage { get; }

        public MasterDetail()
        {
            ContentPage = new ContentPageExemplo();
            NavigationPage = new NavigationPage(new NavigationPageExemplo1());
            TabbedPage = new TabbedPageExemplo();

            MessagingCenter.Subscribe<ContentPageExemplo>(this, "abrirMenu", page => IsPresented = true);
            MessagingCenter.Subscribe<NavigationPageExemplo1>(this, "abrirMenu", page => IsPresented = true);
            MessagingCenter.Subscribe<TabbedPageExemplo>(this, "abrirMenu", page => IsPresented = true);

            MessagingCenter.Subscribe<Menu>(this, "contentPage", menu =>
            {
                IsPresented = false;
                Detail = ContentPage;
            });

            MessagingCenter.Subscribe<Menu>(this, "tabbedPage", menu =>
            {
                IsPresented = false;
                Detail = TabbedPage;
            });

            MessagingCenter.Subscribe<Menu>(this, "navigationPage", menu =>
            {
                IsPresented = false;
                Detail = NavigationPage;
            });


            Master = new Menu();
            Detail = ContentPage;
        }
    }
}
