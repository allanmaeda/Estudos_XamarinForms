using System.ComponentModel;

namespace XF_Aprofundado1.Models
{
    public class InformacaoDetalhe : INotifyPropertyChanged
    {
        private bool _selecionado;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Titulo { get; set; }

        public bool Selecionado
        {
            get => _selecionado;
            set { _selecionado = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Selecionado))); }
        }
    }
}
