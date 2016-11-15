using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_DataBinding8
{
    public class ViewModel
    {
        public ICommand ModificaTexto { get; }

        public ViewModel()
        {
            ModificaTexto = new Command<string>(s =>
            {
                if (!string.IsNullOrEmpty(s))
                    Debug.WriteLine($"Texto modificado: {s.ToUpper()}");
            });
        }
    }


}
