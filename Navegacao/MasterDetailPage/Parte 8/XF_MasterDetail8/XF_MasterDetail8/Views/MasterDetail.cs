using System;
using Xamarin.Forms;
using XF_MasterDetail8.Models;

namespace XF_MasterDetail8.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            Master = new Menu();
            Detail = new NavigationPage(new Detalhe1());

            ((Menu)Master).PublicListView.ItemSelected += (sender, args) =>
            {
                if (!(args.SelectedItem is ItemMenu item))
                    return;

                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Type));

                try
                {
                    IsPresented = false;
                }
                catch (Exception ex)
                {
                    // ignore
                }
                
                ((Menu)Master).PublicListView.SelectedItem = null;
            };

            ((Menu)Master).PublicButton.Clicked += async (sender, args) => await Navigation.PopModalAsync(true);
        }
    }
}
