using Xamarin.Forms;
using XF_MasterDetail2.Model;

namespace XF_MasterDetail2.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            Master = new Menu();
            Detail = new NavigationPage(new Detalhe0());
            ((Menu)Master).PublicListView.ItemSelected += ListViewOnItemSelected;
        }

        private void ListViewOnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is ItemMenu item)
            {
                if (item.Texto == "Detalhe 1")
                    Detail = new NavigationPage(new Detalhe1());
                else if (item.Texto == "Detalhe 2")
                    Detail = new NavigationPage(new Detalhe2());
                else if (item.Texto == "Detalhe 3")
                    Detail = new NavigationPage(new Detalhe3());

                IsPresented = false;
            }

            ((Menu) Master).PublicListView.SelectedItem = null;
        }
    }
}