using System;

namespace XF_ListView5
{
    public class Model
    {
        public string Elemento { get; set; }

        public string Criacao { get; }

        public Model()
        {
            Criacao = DateTime.Now.ToString("HH:mm:ss.FFF");
        }
    }
}
