using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XF_App5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new XF_App5.MainPage();
        }

        protected override void OnStart()
        {
            ModalPopping += async (sender, args) =>
            {
                if (new Random().Next(0, 2) == 0)
                {
                    args.Cancel = true;
                    await args.Modal.DisplayAlert("Atenção", "Há algo errado!", "Ok");
                }
                else
                {
                    await args.Modal.DisplayAlert("Atenção", "Navegação feita!", "Ok");
                }
            };
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
