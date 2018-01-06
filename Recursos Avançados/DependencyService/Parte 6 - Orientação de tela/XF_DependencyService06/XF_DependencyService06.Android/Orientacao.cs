using Android.Content;
using Android.Runtime;
using Android.Views;
using XF_DependencyService06.Abstracao;
using XF_DependencyService06.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(Orientacao))]
namespace XF_DependencyService06.Droid
{
    public class Orientacao : IOrientacao
    {
        public OrientacaoAtual ObterOrientacaoAtual()
        {
            try
            {
                var gerenciadorJanelas = Android.App.Application.Context
                    .GetSystemService(Context.WindowService)
                    .JavaCast<IWindowManager>();

                var orientacao_Android = gerenciadorJanelas.DefaultDisplay.Rotation;

                if (orientacao_Android == SurfaceOrientation.Rotation0)
                    return OrientacaoAtual.Retrato;

                if (orientacao_Android == SurfaceOrientation.Rotation90)
                    return OrientacaoAtual.PaisagemGiroParaAEsquerda;

                if (orientacao_Android == SurfaceOrientation.Rotation180)
                    return OrientacaoAtual.RetratoDeCabecaParaBaixo;

                if (orientacao_Android == SurfaceOrientation.Rotation270)
                    return OrientacaoAtual.PaisagemGiroParaADireita;

                return OrientacaoAtual.Desconhecido;
            }
            catch
            {
                return OrientacaoAtual.Desconhecido;
            }
        }
    }
}