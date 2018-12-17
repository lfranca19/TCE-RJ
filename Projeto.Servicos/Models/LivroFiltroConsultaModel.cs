using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Servicos.Models
{
    public class LivroFiltroConsultaModel
    {
        
        public string ISBN { get; set; }        
        public string Autor { get; set; }        
        public string Nome { get; set; }
        public decimal Preco_Ini { get; set; }
        public decimal Preco_Fim { get; set; }
        public DateTime Data_Ini { get; set; }
        public DateTime Data_Fim { get; set; }
        
    }
}