using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using Projeto.DAL.Mapeamentos;
using Projeto.Entidades;

namespace Projeto.DAL.Contexto
{
    class DataContext : DbContext
    {
        public DataContext() : base(ConfigurationManager.ConnectionStrings["TCE"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LivroMap());            
        }

        public DbSet<Livro> Livro { get; set; }
    }
}
