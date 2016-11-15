using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_DataBinding7
{
    public class ViewModel
    {
        public ICommand Click { get; }

        public void BotaoClicado()
        {
            Debug.WriteLine("funcao chamada");
        }

        public ViewModel()
        {
            Click = new Command(BotaoClicado);
        }
    }
}
