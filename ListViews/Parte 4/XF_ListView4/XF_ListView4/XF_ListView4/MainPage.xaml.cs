using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_ListView4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<Model>
            {
                new Model { Nome = "Angelina Figueira", Idade = 15 },
                new Model { Nome = "Angelino Neiva", Idade = 20 },
                new Model { Nome = "Boaventura Pardo", Idade = 25 },
                new Model { Nome = "Cristóvão Peseiro", Idade = 28 },
                new Model { Nome = "Deolinda Gonçalves", Idade = 18 },
                new Model { Nome = "Diógenes Froes", Idade = 38 },
                new Model { Nome = "Feliciano Themes", Idade = 35 },
                new Model { Nome = "Firmino Campos", Idade = 34 },
                new Model { Nome = "Flor Bonilha", Idade = 30 },
                new Model { Nome = "Frederico Chousa", Idade = 31 },
                new Model { Nome = "Gaspar Negreiros", Idade = 29 },
                new Model { Nome = "Leonardo Ferrera", Idade = 17 },
                new Model { Nome = "Leônidas Carvalhal", Idade = 22 },
                new Model { Nome = "Maíra Mourinho", Idade = 26 },
                new Model { Nome = "Nestor Tomé", Idade = 33 },
                new Model { Nome = "Osvaldo Costa", Idade = 31 },
                new Model { Nome = "Priscila Bento", Idade = 47 },
                new Model { Nome = "Sandoval Rocha", Idade = 19 },
                new Model { Nome = "Tércio Gonsalves", Idade = 28 },
                new Model { Nome = "Veríssimo Porciúncula", Idade = 34 }
            };

        }
    }
}
