using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF_DependencyService05.Implementacao;
using XF_DependencyService05.Interface;
using XF_DependencyService05.Model;

[assembly:Dependency(typeof(ContadorLetras))]
namespace XF_DependencyService05.Implementacao
{
    public class ContadorLetras : IContadorLetras
    {
        private string Expressao { get; set; }
        private TaskCompletionSource<Letras> Source { get; set; }
        public INavigation Navigation { get; set; }
        public MainPage2 MainPage2 { get; }

        public ContadorLetras()
        {
            MainPage2 = new MainPage2();
            MainPage2.PublicButtonCancelar.Clicked += (sender, args) =>
            {
                Navigation.PopModalAsync(true);
                Source.SetResult(null);
            };

            MainPage2.PublicButtonConfirmar.Clicked += async (sender, args) =>
            {
                var letras = new Letras();

                if (MainPage2.PublicSwitchEspacos.IsToggled)
                    letras.Espacos = Expressao.ToCharArray().Count(x => x == ' ');
                if (MainPage2.PublicSwitchVogais.IsToggled)
                    letras.Vogais = Expressao.ToCharArray().Count(x => "aeiou".Contains(x.ToString()));
                if (MainPage2.PublicSwitchConsoantes.IsToggled)
                    letras.Consoantes = Expressao.ToCharArray().Count(x => !"aeiou".Contains(x.ToString()));

                await Navigation.PopModalAsync(true);

                Source.SetResult(letras);
            };
        }

        public Task<Letras> Contar(string expressao)
        {
            Expressao = expressao;
            Source = new TaskCompletionSource<Letras>();
            Navigation.PushModalAsync(MainPage2);
            return Source.Task;
        }
    }
}
