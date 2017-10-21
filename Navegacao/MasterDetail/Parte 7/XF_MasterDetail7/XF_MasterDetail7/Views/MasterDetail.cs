using Xamarin.Forms;

namespace XF_MasterDetail7.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public Menu Menu { get; }

        public Detalhe Detalhe { get; }

        public MasterDetail()
        {
            MessagingCenter.Subscribe<Menu>(this, "abrirDetalhe", menu =>
            {
                if (MasterBehavior != MasterBehavior.Split)
                    IsPresented = false;
            });

            MessagingCenter.Subscribe<Detalhe>(this, "abrirMenu", detalhe =>
            {
                if (MasterBehavior != MasterBehavior.Split)
                    IsPresented = true;
            });

            MessagingCenter.Subscribe<Detalhe>(this, "voltar", detalhe =>
            {
                Navigation.PopModalAsync();
            });

            Menu = new Menu();
            Detalhe = new Detalhe();

            Master = Menu;
            Detail = Detalhe;
        }
    }
}
