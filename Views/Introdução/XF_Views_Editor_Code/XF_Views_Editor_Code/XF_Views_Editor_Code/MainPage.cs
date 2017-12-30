using Xamarin.Forms;

namespace XF_Views_Editor_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var editor = new Editor
            {
                FontSize = 35,
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Gray
            };

            editor.Completed += (sender, args) => System.Diagnostics.Debug.WriteLine("texto completo");
            editor.TextChanged += (sender, args) => System.Diagnostics.Debug.WriteLine("texto editado"); 

            Content = editor;
        }
    }
}
