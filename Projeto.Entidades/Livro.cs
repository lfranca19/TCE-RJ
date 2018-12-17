using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Livro
    {
        public virtual string ISBN { get; set; }
           
        public virtual string Autor { get; set; }
           
        public virtual string Nome { get; set; }
              
        public virtual decimal Preco { get; set; }
         
        public virtual DateTime Data_Publicacao { get; set; }
               
        public virtual byte[] Imagem_Capa { get; set; }
    }
}
