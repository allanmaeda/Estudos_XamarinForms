using System;
using Xamarin.Forms;
using XF_DependencyService07.Interface;

namespace XF_DependencyService07
{
	public partial class MainPage : ContentPage
	{
        public IExemplo Exemplo { get; }

		public MainPage()
		{
			InitializeComponent();
		    Exemplo = DependencyService.Get<IExemplo>();
		}

	    public async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await DisplayAlert("Atenção", Exemplo.Identificacao(), "Ok");
	    }
    }
}
