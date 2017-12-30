using System;
using Xamarin.Forms;
using XF_MasterDetail9.Models;

namespace XF_MasterDetail9.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            Master = new Menu();
            Detail = new NavigationPage(new Detalhe1());

            ((Menu) Master).PublicListView.ItemSelected += (sender, args) =>
            {
                if (!(args.SelectedItem is ItemMenu item))
                    return;

                ((Menu) Master).PublicListView.SelectedItem = null;
                Detail = new NavigationPage((Page) Activator.CreateInstance(item.Type));

                if (MasterBehavior == MasterBehavior.Popover)
                    IsPresented = false;
            };

            SizeChanged += (sender, args) =>
            {
                if (Width > Height)
                {
                    IsPresented = true;
                    MasterBehavior = MasterBehavior.Split;
                }
                else
                {
                    MasterBehavior = MasterBehavior.Popover;
                    ((IMasterDetailPageController)this).CanChangeIsPresented = true;
                    IsPresented = true;
                }
            };
        }
    }
}
