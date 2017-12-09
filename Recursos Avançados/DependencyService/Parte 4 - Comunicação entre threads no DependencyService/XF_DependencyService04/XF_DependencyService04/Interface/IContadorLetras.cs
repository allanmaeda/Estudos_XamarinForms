using System.Threading.Tasks;
using XF_DependencyService04.Model;

namespace XF_DependencyService04.Interface
{
    public interface IContadorLetras
    {
        bool ContarVogais { get; set; }

        bool ContarConsonantes { get; set; }

        bool ContarEspacos { get; set; }

        Task<Letras> Contar(string frase);

        void Comecar();
    }
}
