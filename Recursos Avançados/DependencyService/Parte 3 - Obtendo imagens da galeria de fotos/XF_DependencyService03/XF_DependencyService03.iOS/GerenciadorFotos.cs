using System;
using System.IO;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using XF_DependencyService03.iOS;

[assembly:Xamarin.Forms.Dependency(typeof(GerenciadorFotos))]
namespace XF_DependencyService03.iOS
{
    public class GerenciadorFotos : IGerenciadorFotos
    {
        UIImagePickerController _imagePicker;
        TaskCompletionSource<Stream> _taskCompletionSource;

        public Task<Stream> ObterFoto()
        {
            _imagePicker = new UIImagePickerController
            {
                SourceType = UIImagePickerControllerSourceType.PhotoLibrary,
                MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary)
            };

            _imagePicker.FinishedPickingMedia += OnImagePickerFinishedPickingMedia;
            _imagePicker.Canceled += OnImagePickerCancelled;

            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            var viewController = window.RootViewController;
            viewController.PresentModalViewController(_imagePicker, true);

            _taskCompletionSource = new TaskCompletionSource<Stream>();
            return _taskCompletionSource.Task;
        }

        private void OnImagePickerCancelled(object sender, EventArgs args)
        {
            _taskCompletionSource.SetResult(null);
            _imagePicker.DismissModalViewController(true);
        }

        private void OnImagePickerFinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            UIImage image = e.EditedImage ?? e.OriginalImage;

            if (image != null)
            {
                NSData data = image.AsJPEG(1);
                Stream stream = data.AsStream();

                _taskCompletionSource.SetResult(stream);
            }
            else
            {
                _taskCompletionSource.SetResult(null);
            }
            _imagePicker.DismissModalViewController(true);
        }
    }
}