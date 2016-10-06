using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModalEventosEventArgs
{
    public partial class ModalPage : ContentPage
    {
        // event handler que aceita funções com ExemploEventArgs
        public event EventHandler<ExemploEventArgs> ModalHandler;

        public event EventHandler teste;

        public ModalPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            // criando o objeto ExemploEventArgs, que será passado
            var date = DateTime.Now;
            var args = new ExemploEventArgs
            {
                Data = date.ToString("dd/MM/yyyy"),
                Hora = date.ToString("HH:mm:ss")
            };

            // invocando possiveis funcoes anexadas
            ModalHandler?.Invoke(Entry.Text, args);

            await Navigation.PopModalAsync(true);
        }
    }
}
