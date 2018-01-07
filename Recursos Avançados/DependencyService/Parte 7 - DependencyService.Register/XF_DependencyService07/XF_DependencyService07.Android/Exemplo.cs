using XF_DependencyService07.Interface;

namespace XF_DependencyService07.Droid
{
    public class Exemplo : IExemplo
    {
        public string Identificacao()
        {
            return "Esta código foi executado no Android";
        }
    }
}