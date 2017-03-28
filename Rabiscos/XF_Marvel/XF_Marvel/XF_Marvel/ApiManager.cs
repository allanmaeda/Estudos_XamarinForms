using System;
using System.Net.Http;
using Xamarin.Forms;
using XF_Marvel.Interfaces;

namespace XF_Marvel
{
    public class ApiManager : IApiManager
    {
        private const string PublicKey = "a3d960d23783d42104506dd345a27585";
        private const string PrivateKey = "776e595a8174726030235df8cf39ecc5b7074dc8";

        public string ObterPersonagens()
        {
            var hashService = DependencyService.Get<IHashApi>();
            var ts = DateTime.Now.ToString("ddMMyyyyHHmmss");
            var hash =  hashService.ObterHash(ts + PrivateKey + PublicKey);
            var address = "http://gateway.marvel.com/v1/public/characters?ts=" + ts + "&apikey=" + PublicKey + "&hash=" + hash + "&limit=30";
            return GetResult(address);
        }

        public string ObterDetalhePersonagem(int id)
        {
            var hashService = DependencyService.Get<IHashApi>();
            var ts = DateTime.Now.ToString("ddMMyyyyHHmmss");
            var hash = hashService.ObterHash(ts + PrivateKey + PublicKey);
            var address = "http://gateway.marvel.com/v1/public/characters/" + id + "?ts=" + ts + "&apikey=" + PublicKey + "&hash=" + hash + "&limit=30";
            return GetResult(address);
        }

        public string ObterDetalheComic(string uriComic)
        {
            var hashService = DependencyService.Get<IHashApi>();
            var ts = DateTime.Now.ToString("ddMMyyyyHHmmss");
            var hash = hashService.ObterHash(ts + PrivateKey + PublicKey);
            var address = uriComic + "?ts=" + ts + "&apikey=" + PublicKey + "&hash=" + hash;
            return GetResult(address);
        }

        public string GetResult(string entry)
        {
            var client = new HttpClient();
            return client.GetStringAsync(entry).Result;
        }
    }
}
