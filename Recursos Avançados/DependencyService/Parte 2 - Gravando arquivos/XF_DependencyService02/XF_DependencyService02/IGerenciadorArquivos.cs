using System.Threading.Tasks;

namespace XF_DependencyService02
{
    public interface IGerenciadorArquivos
    {
        Task SalvarArquivo(string nomeArquivo, string conteudoArquivo);

        Task<string> CarregarArquivo(string nomeArquivo);
    }
}
