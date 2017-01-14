using System;

namespace XF_ListView7
{
    public class Model
    {
        public string InformacaoPrincipal { get; }

        public string InformacaoSecundaria { get; }

        public string Hora { get; }

        public Model(string principal, string secundaria)
        {
            InformacaoPrincipal = principal;
            InformacaoSecundaria = secundaria;
            Hora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.FFF");
        }
    }
}
