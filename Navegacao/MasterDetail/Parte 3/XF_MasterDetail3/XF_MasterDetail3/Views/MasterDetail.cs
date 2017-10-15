using System;
using Xamarin.Forms;
using XF_MasterDetail3.Models;

namespace XF_MasterDetail3.Views
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
            if (!(e.SelectedItem is ItemMenu item))
                return;

            Detail = new NavigationPage((Page)Activator.CreateInstance(item.Type));
            IsPresented = false;
            ((Menu) Master).PublicListView.SelectedItem = null;
        }
    }
}
