using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_CarouselPage11
{
    public class Elemento : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _titulo;
        private Color _color;

        public string Titulo
        {
            get => _titulo;
            set { _titulo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Titulo))); }
        }

        public Color Cor
        {
            get => _color;
            set { _color = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cor))); }
        }

        public ICommand Command { get; set; }

        public Elemento(INavigation navigation)
        {
            Command = new Command(() =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await navigation.PushModalAsync(new Page1(this));
                });
            });
        }
    }
}
