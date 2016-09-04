using Xamarin.Forms;

namespace XF_ScrollView_Parte1
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label {Text = "Campo 1"},
                        new Entry(),
                        new Label {Text = "Campo 2"},
                        new Entry(),
                        new Label {Text = "Campo 3"},
                        new Entry(),
                        new Label {Text = "Campo 4"},
                        new Entry(),
                        new Label {Text = "Campo 5"},
                        new Entry(),
                        new Label {Text = "Campo 6"},
                        new Entry(),
                        new Label {Text = "Campo 7"},
                        new Entry(),
                        new Label {Text = "Campo 8"},
                        new Entry(),
                        new Label {Text = "Campo 9"},
                        new Entry(),
                        new Label {Text = "Campo 10"},
                        new Entry()
                    }
                }
            };
        }
    }
}

