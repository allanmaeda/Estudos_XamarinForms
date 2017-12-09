using System.Linq;
using System.Threading.Tasks;
using XF_DependencyService04.Implementação;
using XF_DependencyService04.Interface;
using XF_DependencyService04.Model;

[assembly: Xamarin.Forms.Dependency(typeof(ContadorLetras))]
namespace XF_DependencyService04.Implementação
{
    public class ContadorLetras : IContadorLetras
    {
        public bool ContarVogais { get; set; }
        public bool ContarConsonantes { get; set; }
        public bool ContarEspacos { get; set; }

        private string Expressao { get; set; }
        private TaskCompletionSource<Letras> Source { get; set; }

        public Task<Letras> Contar(string expressao)
        {
            Source = new TaskCompletionSource<Letras>();
            Expressao = expressao?.ToLower();
            return Source.Task;
        }

        public void Comecar()
        {
            if (string.IsNullOrEmpty(Expressao))
            {
                Source.SetResult(null);
            }
            else
            {
                var letras = new Letras();

                if (ContarEspacos)
                    letras.Espacos = Expressao.ToCharArray().Count(x => x == ' ');
                if (ContarVogais)
                    letras.Vogais = Expressao.ToCharArray().Count(x => "aeiou".Contains(x.ToString()));
                if (ContarConsonantes)
                    letras.Consoantes = Expressao.ToCharArray().Count(x => !"aeiou".Contains(x.ToString()));

                Source.SetResult(letras);
            }
        }
    }
}
