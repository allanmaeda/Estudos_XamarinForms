using XF_DependencyService01.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(ExemploNoIos))]
namespace XF_DependencyService01.iOS
{
    public class ExemploNoIos : IExemplo
    {
        public string MensagemCustomizada()
        {
            return "Esta mensagem só existe no iOS";
        }
    }
}