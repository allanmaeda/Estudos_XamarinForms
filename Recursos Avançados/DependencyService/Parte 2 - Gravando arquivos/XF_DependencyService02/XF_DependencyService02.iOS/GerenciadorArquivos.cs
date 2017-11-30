using System;
using System.IO;
using System.Threading.Tasks;
using XF_DependencyService02.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(GerenciadorArquivos))]
namespace XF_DependencyService02.iOS
{
    public class GerenciadorArquivos : IGerenciadorArquivos
    {
        public async Task SalvarArquivo(string nomeArquivo, string conteudoArquivo)
        {
            var caminhoPastaPessoal = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var caminhoCompleto = Path.Combine(caminhoPastaPessoal, nomeArquivo);

            using (var stream = new StreamWriter(caminhoCompleto, false))
            {
                stream.AutoFlush = true;
                await stream.WriteAsync(conteudoArquivo);
            }
        }

        public async Task<string> CarregarArquivo(string nomeArquivo)
        {
            var caminhoPastaPessoal = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var caminhoCompleto = Path.Combine(caminhoPastaPessoal, nomeArquivo);

            using (var stream = new StreamReader(caminhoCompleto))
            {
                return await stream.ReadToEndAsync();
            }
        }
    }
}