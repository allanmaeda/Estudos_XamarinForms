using System;

namespace XF_ListView6
{
    public class Model
    {
        public string Conteudo { get; set; }

        public string Hora { get; }

        public Model()
        {
            Hora = DateTime.Now.ToString("HH:mm:ss.FFF");
        }
    }
}
