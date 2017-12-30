using System;
using Xamarin.Forms;

namespace XF_Entry4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Entry.Focused += EntryChangedFocus;
            Entry.Unfocused += EntryChangedFocus;
        }

        private void EntryChangedFocus(object sender, FocusEventArgs focusEventArgs)
        {
            if (focusEventArgs.IsFocused)
                Label.Text = $"Entry foi focada em {DateTime.Now:HH:mm:ss}";
            else
                Label.Text = $"Entry foi desfocada em {DateTime.Now:HH:mm:ss}";
        }
    }
}
