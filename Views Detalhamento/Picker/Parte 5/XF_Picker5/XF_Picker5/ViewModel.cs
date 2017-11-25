using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace XF_Picker5
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Elemento _elementoSelecionado;

        public List<Elemento> Elementos { get; set; }

        public Elemento ElementoSelecionado
        {
            get => _elementoSelecionado;
            set { _elementoSelecionado = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ElementoSelecionado))); }
        }
    }
}
