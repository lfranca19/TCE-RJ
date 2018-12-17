using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades; 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Projeto.DAL.Mapeamentos
{
    class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livros");

            HasKey(l => l.ISBN);

            Property(l => l.ISBN)
                .HasColumnName("ISBN")
                .IsRequired();

            Property(l => l.Autor)
                .HasColumnName("Autor")
                .HasMaxLength(50)
                .IsRequired();

            Property(l => l.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(l => l.Preco)
                .HasColumnName("Preco")                
                .IsRequired();

            Property(l => l.Data_Publicacao)
                .HasColumnName("Data_Publicacao")                
                .IsRequired();

            Property(l => l.Imagem_Capa)
                .HasColumnName("Imagem_Capa");                
                
        }
    }
}
