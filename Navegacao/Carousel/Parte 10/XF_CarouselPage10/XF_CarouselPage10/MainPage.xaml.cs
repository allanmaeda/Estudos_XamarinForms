using System.Collections.Generic;
using Xamarin.Forms;

namespace XF_CarouselPage10
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            ItemsSource = new List<Elemento>
            {
                new Elemento
                {
                    Titulo = "Página 1",
                    Cor = Color.Red
                },
                new Elemento
                {
                    Titulo = "Página 2",
                    Cor = Color.Yellow
                },
                new Elemento
                {
                    Titulo = "Página 3",
                    Cor = Color.Green
                }
            };
        }
    }
}
