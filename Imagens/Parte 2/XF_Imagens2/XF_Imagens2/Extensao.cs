using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Imagens2
{
    [ContentProperty("Source")]
    public class Extensao : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source);
            return imageSource;
        }
    }
}
