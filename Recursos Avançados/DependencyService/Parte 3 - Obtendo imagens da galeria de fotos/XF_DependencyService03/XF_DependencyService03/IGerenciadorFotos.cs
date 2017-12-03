using System.IO;
using System.Threading.Tasks;

namespace XF_DependencyService03
{
    public interface IGerenciadorFotos
    {
        Task<Stream> ObterFoto();
    }
}
