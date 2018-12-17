using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Servicos.Models
{
    public class LivroCadastroModel
    {
        [Required(ErrorMessage = "Informe o ISBN")]
        public string ISBN { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres para o Autor.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres para o Autor.")]
        public string Autor { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres para o nome do livro.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres para o nome do livro.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o preco")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe a Data de Publicação")]
        public DateTime Data_Publicacao { get; set; }
                
        public byte[] Imagem_Capa { get; set; }
    }
}