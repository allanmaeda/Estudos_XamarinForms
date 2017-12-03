using System.IO;
using System.Threading.Tasks;
using Android.Content;
using Xamarin.Forms;
using XF_DependencyService03.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(GerenciadorFotos))]
namespace XF_DependencyService03.Droid
{
    public class GerenciadorFotos : IGerenciadorFotos
    {
        public Task<Stream> ObterFoto()
        {
            var intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            MainActivity activity = Forms.Context as MainActivity;

            activity.StartActivityForResult(
                Intent.CreateChooser(intent, "Select Picture"),
                MainActivity.PickImageId);

            activity.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

            return activity.PickImageTaskCompletionSource.Task;
        }
    }
}