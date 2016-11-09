using System.ComponentModel;

namespace XF_DataBinding5
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nome;
        private string _sobrenome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
            }
        }

        public string Sobrenome
        {
            get { return _sobrenome; }
            set
            {
                _sobrenome = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sobrenome)));
            }
        }
    }
}
