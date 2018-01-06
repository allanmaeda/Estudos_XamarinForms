using Xamarin.Forms;
using XF_DependencyService06.Abstracao;

namespace XF_DependencyService06
{
	public partial class MainPage : ContentPage
	{
        public IOrientacao Orientacao { get; }

		public MainPage()
		{
			InitializeComponent();
		    Orientacao = DependencyService.Get<IOrientacao>();
            SizeChanged += MainPage_SizeChanged;
		}

        private void MainPage_SizeChanged(object sender, System.EventArgs e)
        {
            var orientacao = Orientacao.ObterOrientacaoAtual();

            switch (orientacao)
            {
                case OrientacaoAtual.Retrato:
                    Label.Text = "Aparelho está de pé";
                    break;
                case OrientacaoAtual.RetratoDeCabecaParaBaixo:
                    Label.Text = "Aparelho está de cabeça para baixo";
                    break;
                case OrientacaoAtual.PaisagemGiroParaAEsquerda:
                    Label.Text = "Aparelho deitou para a esquerda";
                    break;
                case OrientacaoAtual.PaisagemGiroParaADireita:
                    Label.Text = "Aparelho deitou para a direita";
                    break;
                default:
                    Label.Text = "Não foi possível obter a orientação";
                    break;
            }
        }
    }
}
