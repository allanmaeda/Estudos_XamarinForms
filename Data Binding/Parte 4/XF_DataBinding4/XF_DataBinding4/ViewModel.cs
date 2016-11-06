using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XF_DataBinding4
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime _dataAtual;
        public DateTime DataAtual
        {
            set
            {
                if (_dataAtual == value)
                    return;

                _dataAtual = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DataAtual)));
            }
            get
            {
                return _dataAtual;
            }
        }

        public ViewModel()
        {
            DataAtual = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                DataAtual = DateTime.Now;
                return true;
            });
        }
    }
}
