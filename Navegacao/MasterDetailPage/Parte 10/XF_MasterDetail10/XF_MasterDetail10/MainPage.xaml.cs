using System;
using Xamarin.Forms;
using XF_MasterDetail10.Detalhes;

namespace XF_MasterDetail10
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Master = new Menu();
            Detail = new NavigationPage(new ContentPage
            {
                Content = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Text = "Abra o menu para navegar"
                }
            });

            ((Menu)Master).PublicListView.ItemSelected += (sender, args) =>
            {
                if (((ItemMenu) args.SelectedItem).Carrossel)
                {
                    Detail = new NavigationPage((Carrossel) Activator.CreateInstance(((ItemMenu) args.SelectedItem).Type));
                }
                else
                {
                    Detail = new NavigationPage((ContentPage)Activator.CreateInstance(((ItemMenu)args.SelectedItem).Type));
                }

                IsPresented = false;
            };
        }
    }
}
