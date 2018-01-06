namespace XF_DependencyService06.Abstracao
{
    public enum OrientacaoAtual
    {
        Retrato,
        RetratoDeCabecaParaBaixo,
        PaisagemGiroParaAEsquerda,
        PaisagemGiroParaADireita,
        Desconhecido
    }

    public interface IOrientacao
    {
        OrientacaoAtual ObterOrientacaoAtual();
    }
}
