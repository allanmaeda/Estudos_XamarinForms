using System.ComponentModel;

namespace XF_Picker4
{
    public class Elemento : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _valorVisual;
        private int _valorReal;

        public string ValorVisual
        {
            get => _valorVisual;
            set
            {
                _valorVisual = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ValorVisual)));
            }
        }

        public int ValorReal
        {
            get => _valorReal;
            set
            {
                _valorReal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ValorReal)));
            }
        }
    }
}
