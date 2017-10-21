using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetail4.Models;
using XF_MasterDetail4.Views;

namespace XF_MasterDetail4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            InitializeComponent();

            ((Menu) Master).PublicListView.ItemSelected += (sender, args) =>
            {
                if (!(args.SelectedItem is ItemMenu item))
                    return;

                ((Menu)Master).PublicListView.SelectedItem = null;
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Type));
                IsPresented = false;
            };
        }
    }
}