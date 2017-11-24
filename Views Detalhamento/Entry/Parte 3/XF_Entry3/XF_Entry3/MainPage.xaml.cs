using Xamarin.Forms;

namespace XF_Entry3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Entry1.Completed += (sender, args) =>
            {
                Entry2.IsEnabled = true;
                if (string.IsNullOrEmpty(Entry2.Text))
                    Entry2.Focus();
            };

            Entry2.Completed += (sender, args) =>
            {
                Entry3.IsEnabled = true;
                if (string.IsNullOrEmpty(Entry3.Text))
                    Entry3.Focus();
            };

            Entry1.Unfocused += async (sender, args) =>
            {
                if (string.IsNullOrEmpty(Entry1.Text))
                {
                    await DisplayAlert("Atenção", "Digite a mensagem!", "Ok");
                    Entry1.Focus();
                }
                else
                {
                    Entry1.SendCompleted();
                }
            };

            Entry2.Unfocused += async (sender, args) =>
            {
                if (string.IsNullOrEmpty(Entry2.Text))
                {
                    await DisplayAlert("Atenção", "Digite a mensagem!", "Ok");
                    Entry2.Focus();
                }
                else
                {
                    Entry2.SendCompleted();
                }
            };

            Entry3.Unfocused += async (sender, args) =>
            {
                if (string.IsNullOrEmpty(Entry3.Text))
                {
                    await DisplayAlert("Atenção", "Digite a mensagem!", "Ok");
                    Entry3.Focus();
                }
            };
        }
    }
}
