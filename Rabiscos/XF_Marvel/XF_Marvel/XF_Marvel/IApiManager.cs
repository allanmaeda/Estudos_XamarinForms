namespace XF_Marvel
{
    public interface IApiManager
    {
        string ObterPersonagens();

        string ObterDetalhePersonagem(int id);

        string ObterDetalheComic(string uriComic);
    }
}
