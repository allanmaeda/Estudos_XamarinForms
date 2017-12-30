using System.Collections.Generic;
using Xamarin.Forms;

namespace XF_ListView2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // criando a lista de objetos para a lista
            var lista = new List<Model>
            {
                new Model { Nome = "Fulano", Sobrenome = "de Souza", Idade = 20 },
                new Model { Nome = "Sicrana", Sobrenome = "Motta", Idade = 25 },
                new Model { Nome = "Beltrano", Sobrenome = "Almeida", Idade = 30},
                new Model { Nome = "Luis", Sobrenome = "Carvalho", Idade = 34},
                new Model { Nome = "Clara", Sobrenome = "Fernandes", Idade = 28},
                new Model { Nome = "Luis", Sobrenome = "Gomes", Idade = 55},
                new Model { Nome = "Gabriela", Sobrenome = "Santos", Idade = 46},
                new Model { Nome = "Tânia", Sobrenome = "Souza", Idade = 47},
                new Model { Nome = "Alice", Sobrenome = "Castro", Idade = 70},
                new Model { Nome = "Diego", Sobrenome = "Campos", Idade = 76},
                new Model { Nome = "Igor", Sobrenome = "Alves", Idade = 36},
                new Model { Nome = "Kauan", Sobrenome = "Cunha", Idade = 32},
                new Model { Nome = "Clara", Sobrenome = "Lima", Idade = 48},
                new Model { Nome = "Vitória", Sobrenome = "Melo", Idade = 61},
                new Model { Nome = "Rafaela", Sobrenome = "Costa", Idade = 54},
                new Model { Nome = "Marina", Sobrenome = "Barbosa", Idade = 74},
                new Model { Nome = "João", Sobrenome = "Castro", Idade = 81}
            };

            var dataTemplate = new DataTemplate(typeof(TextCell));
            dataTemplate.SetBinding(TextCell.TextProperty, "Nome");
            dataTemplate.SetBinding(TextCell.DetailProperty, "Sobrenome");


            var listView = new ListView
            {
                ItemsSource = lista,
                ItemTemplate = dataTemplate
            };

            Content = listView;

        }
    }
}
