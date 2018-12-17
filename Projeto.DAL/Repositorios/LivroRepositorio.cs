using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.DAL.Contexto;
using Projeto.Entidades;
using Projeto.DAL.Util;

namespace Projeto.DAL.Repositorios
{
    public class LivroRepositorio : BaseRepositorio<Livro>
    {
        public List<Livro> SelectAllLivro(string isbn, string autor, string nome, decimal valIni, decimal valFim, DateTime dataIni, DateTime dataFim)
        {

            var predicate = PredicateBuilder2.True<Livro>();

            if (isbn != null)
            {
                predicate = predicate.And(p => p.ISBN.Contains(isbn));
            }

            if (autor != null)
            {
                predicate = predicate.And(p => p.Autor.Contains(autor));
            }

            if (nome != null)
            {
                predicate = predicate.And(p => p.Nome.Contains(nome));
            }

            if (valIni > 0)
            {
                predicate = predicate.And(p => p.Preco >= valIni);
            }

            if (valFim > 0)
            {
                predicate = predicate.And(p => p.Preco <= valFim);
            }
                    
            if (dataIni != null && dataIni != DateTime.MinValue && dataIni != DateTime.MaxValue)
            {
                predicate = predicate.And(p => p.Data_Publicacao >= dataIni);
            }

            if (dataFim != null && dataFim != DateTime.MinValue && dataFim != DateTime.MaxValue)
            {
                predicate = predicate.And(p => p.Data_Publicacao <= dataFim);
            }

            using (DataContext d = new DataContext())
            {

                return d.Livro                         
                        .AsExpandable()
                        .Where(predicate)
                        .ToList();
            }

        }
    }
}
