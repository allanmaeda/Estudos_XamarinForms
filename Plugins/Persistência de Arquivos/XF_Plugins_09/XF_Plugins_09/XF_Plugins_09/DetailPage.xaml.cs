using PCLExt.FileStorage;
using PCLExt.FileStorage.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Plugins_09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage (IFile file)
        {
            InitializeComponent();
            Editor.Text = file.ReadAllText();
        }
    }
}