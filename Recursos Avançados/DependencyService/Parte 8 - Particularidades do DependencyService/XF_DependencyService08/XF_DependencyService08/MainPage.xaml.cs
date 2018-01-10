using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_DependencyService08
{
	public partial class MainPage : ContentPage
	{
        public IExemploAlerta ExemploAlerta { get; }

		public MainPage()
		{
			InitializeComponent();

		    try
		    {
		        ExemploAlerta = DependencyService.Get<IExemploAlerta>();
		    }
		    catch
		    {
		        ExemploAlerta = null;
		    }
		}

	    public async void Button_Clicked(object sender, EventArgs e)
	    {
	        if (ExemploAlerta != null)
	            await DisplayAlert("Atenção", ExemploAlerta.MostrarMensagem(), "Ok");
	    }
	}
}
