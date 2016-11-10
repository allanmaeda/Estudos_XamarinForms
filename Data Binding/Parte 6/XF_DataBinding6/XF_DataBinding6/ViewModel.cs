using System.ComponentModel;

namespace XF_DataBinding6
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double TempOut { get; private set; }

        public double TempIn
        {
            set
            {
                TempOut = value*1.8 + 32;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TempOut)));
            }
        }        
    }
}
