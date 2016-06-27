using Xamarin.Forms;

namespace XF_Views_Label_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var newLabel = new Label
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mollis eros purus, vitae pulvinar turpis sagittis vitae. Sed id urna eget risus consequat molestie quis quis arcu. Proin nisl est, pharetra nec quam a, sollicitudin bibendum erat. Vestibulum pulvinar, neque feugiat vulputate luctus, tortor lorem aliquet felis, eget dapibus risus quam sed nisi. Mauris sed egestas mi. Ut tincidunt dolor metus, in dignissim mi consequat et. Ut nisl mauris, gravida at leo at, luctus faucibus ipsum. Donec sit amet turpis at leo mattis porta. Nam vitae augue in ex dictum finibus. Duis ullamcorper eros at mi consequat placerat. Aenean magna lacus, pharetra a placerat sed, varius at mi. Fusce velit lacus, dignissim et lacus at, tincidunt luctus nulla. Maecenas a mi egestas, fringilla ligula non, dapibus nunc. Ut blandit condimentum sodales. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Aenean nec erat at quam aliquam hendrerit.",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = 15,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromRgb(200, 100, 200)
            };

            Content = newLabel;
        }
    }
}
