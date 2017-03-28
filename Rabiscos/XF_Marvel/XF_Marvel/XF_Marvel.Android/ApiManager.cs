using Xamarin.Forms;

[assembly: Dependency(typeof(XF_Marvel.Droid.ApiManager))]
namespace XF_Marvel.Droid
{
    public class ApiManager : IApiManager
    {
        public Andrade.Paulo.Apimanager.Manager Manager { get; }

        public ApiManager()
        {
            Manager = new Andrade.Paulo.Apimanager.Manager();
        }

        public string ObterPersonagens()
        {
            return Manager.ObterPersonagens();
        }

        public string ObterDetalheComic(string uriComic)
        {
            return Manager.ObterDetalheComic(uriComic);
        }

        public string ObterDetalhePersonagem(int id)
        {
            return Manager.ObterDetalhePersonagem(id);
        }
    }
}