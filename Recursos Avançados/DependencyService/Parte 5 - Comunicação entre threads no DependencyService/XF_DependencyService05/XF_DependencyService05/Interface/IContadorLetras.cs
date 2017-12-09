using System.Threading.Tasks;
using Xamarin.Forms;
using XF_DependencyService05.Model;

namespace XF_DependencyService05.Interface
{
    public interface IContadorLetras
    {
        INavigation Navigation { get; set; }

        Task<Letras> Contar(string frase);
    }
}
