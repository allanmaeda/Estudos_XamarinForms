using System.ComponentModel;

namespace XF_MessagingCenter8
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _info1;
        private string _info2;
        private double _info3;

        public string Informacao1
        {
            get => _info1;
            set { _info1 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Informacao1))); }
        }

        public string Informacao2
        {
            get => _info2;
            set { _info2 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Informacao2))); }
        }

        public double Informacao3
        {
            get => _info3;
            set { _info3 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Informacao3))); }
        }
    }
}
