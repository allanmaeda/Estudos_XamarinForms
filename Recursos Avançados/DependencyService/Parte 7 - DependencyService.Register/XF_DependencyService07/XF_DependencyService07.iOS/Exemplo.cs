using XF_DependencyService07.Interface;

namespace XF_DependencyService07.iOS
{
    public class Exemplo : IExemplo
    {
        public string Identificacao()
        {
            return "Esta código foi executado no iOS";
        }
    }
}