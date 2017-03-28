using System.Security.Cryptography;
using System.Text;
using Xamarin.Forms;
using XF_Marvel.Interfaces;

[assembly: Dependency(typeof(XF_Marvel.Droid.HashApi))]
namespace XF_Marvel.Droid
{
    public class HashApi : IHashApi
    {
        public string ObterHash(string info)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(info);
            var hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hash)
                sb.Append(t.ToString("x2"));
            return sb.ToString();
        }
    }
}