using XF_DependencyService01.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ExemploNoAndroid))]
namespace XF_DependencyService01.Droid
{
    public class ExemploNoAndroid : IExemplo
    {
        public string MensagemCustomizada()
        {
            return "Esta mensagem só existe no Android";
        }
    }
}