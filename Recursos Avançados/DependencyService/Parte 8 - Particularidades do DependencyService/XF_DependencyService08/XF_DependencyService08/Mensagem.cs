using System;
using XF_DependencyService08;

[assembly:Xamarin.Forms.Dependency(typeof(Mensagem))]
namespace XF_DependencyService08
{
    public class Mensagem : IMensagem
    {
        public string ExemploMensagem()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
