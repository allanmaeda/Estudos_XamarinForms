using System;
using Xamarin.Forms;
using XF_MasterDetail5.Models;

namespace XF_MasterDetail5.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            Master = new Menu();
            Detail = new Detalhe1();

            MessagingCenter.Subscribe<Detalhe1>(this, "abrirMenu", Callback);
            MessagingCenter.Subscribe<Detalhe2>(this, "abrirMenu", Callback);

            ((Menu) Master).PublicListView.ItemSelected += (sender, args) =>
            {
                if (!(args.SelectedItem is ItemMenu item))
                    return;

                ((Menu) Master).PublicListView.SelectedItem = null;
                IsPresented = false;
                Detail = (Page) Activator.CreateInstance(item.Type);
            };
        }

        private void Callback(ContentPage page)
        {
            IsPresented = true;
        }
    }
}
