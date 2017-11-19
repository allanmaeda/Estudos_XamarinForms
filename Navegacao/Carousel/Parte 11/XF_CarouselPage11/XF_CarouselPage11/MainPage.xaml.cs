using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_CarouselPage11
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            ItemsSource = new ObservableCollection<Elemento>
            {
                new Elemento(Navigation)
                {
                    Titulo = "Página 1",
                    Cor = Color.Blue
                },
                new Elemento(Navigation)
                {
                    Titulo = "Página 2",
                    Cor = Color.Orange
                }
            };
        }
    }
}
