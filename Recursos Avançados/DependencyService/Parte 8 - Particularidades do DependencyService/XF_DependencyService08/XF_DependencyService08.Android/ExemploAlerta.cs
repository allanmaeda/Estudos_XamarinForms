using Xamarin.Forms;
using XF_DependencyService08.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(ExemploAlerta))]
namespace XF_DependencyService08.Droid
{
    public class ExemploAlerta : IExemploAlerta
    {
        public IMensagem Mensagem { get; }

        public ExemploAlerta()
        {
            Mensagem = DependencyService.Get<IMensagem>();
        }

        public string MostrarMensagem()
        {
            return $"Estamos no Android mostrando a mensagem: {Mensagem.ExemploMensagem()}";
        }
    }
}