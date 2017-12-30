using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CarouselPage11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Elemento Elemento { get; }
        public Page1(Elemento el)
        {
            Elemento = el;
            InitializeComponent();
            Entry.Text = el.Titulo;
        }

        private async void ButtonVoltar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        private async void ButtonConfirmar_OnClicked(object sender, EventArgs e)
        {
            Elemento.Titulo = Entry.Text;
            switch (Picker.SelectedIndex)
            {
                case 0:
                    Elemento.Cor = Color.Black;
                    break;
                case 1:
                    Elemento.Cor = Color.Gray;
                    break;
                case 2:
                    Elemento.Cor = Color.Red;
                    break;
                case 3:
                    Elemento.Cor = Color.Green;
                    break;
            }

            await Navigation.PopModalAsync(true);
        }
    }
}