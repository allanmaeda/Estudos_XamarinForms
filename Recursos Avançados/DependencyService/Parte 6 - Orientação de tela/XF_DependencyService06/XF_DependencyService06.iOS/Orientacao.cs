using UIKit;
using XF_DependencyService06.Abstracao;
using XF_DependencyService06.iOS;

[assembly:Xamarin.Forms.Dependency(typeof(Orientacao))]
namespace XF_DependencyService06.iOS
{
    public class Orientacao : IOrientacao
    {
        public OrientacaoAtual ObterOrientacaoAtual()
        {
            try
            {
                var orienacao_iOS = UIApplication.SharedApplication.StatusBarOrientation;

                if (orienacao_iOS == UIInterfaceOrientation.Portrait)
                    return OrientacaoAtual.Retrato;

                if (orienacao_iOS == UIInterfaceOrientation.PortraitUpsideDown)
                    return OrientacaoAtual.RetratoDeCabecaParaBaixo;

                if (orienacao_iOS == UIInterfaceOrientation.LandscapeLeft)
                    return OrientacaoAtual.PaisagemGiroParaADireita;

                if (orienacao_iOS == UIInterfaceOrientation.LandscapeRight)
                    return OrientacaoAtual.PaisagemGiroParaAEsquerda;

                return OrientacaoAtual.Desconhecido;
            }
            catch
            {
                return OrientacaoAtual.Desconhecido;
            }
        }
    }
}