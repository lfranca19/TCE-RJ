using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Servicos.Models
{
    public class LivroConsultaModel
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public virtual DateTime Data_Publicacao { get; set; }
        public virtual byte[] Imagem_Capa { get; set; }
    }
}