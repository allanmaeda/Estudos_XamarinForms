using System.Collections.Generic;

namespace XF_Aprofundado1.Models
{
    public class Informacao
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public List<InformacaoDetalhe> Detalhes { get; set; }

        public Informacao()
        {
            Detalhes = new List<InformacaoDetalhe>();

            for (var i = 0; i < 25; i++)
            {
                Detalhes.Add(new InformacaoDetalhe
                {
                    Titulo = $"Detalhe de número {i + 1}"
                });
            }
        }
    }
}
