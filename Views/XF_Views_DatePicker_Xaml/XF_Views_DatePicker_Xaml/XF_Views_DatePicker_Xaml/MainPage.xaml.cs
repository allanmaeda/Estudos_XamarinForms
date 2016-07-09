using Xamarin.Forms;

namespace XF_Views_DatePicker_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Data antiga: {e.OldDate.ToString("yy-MM-dd")}");
            System.Diagnostics.Debug.WriteLine($"Data nova: {e.NewDate.ToString("yy-MM-dd")}");
        }
    }
}
