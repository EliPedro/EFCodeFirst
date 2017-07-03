using System.Data.Entity.ModelConfiguration;
using EFCodeFirst.Dominio.Entidades;

namespace Infra.Data.Mapeamento
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {

        public PessoaMap()
        {

            HasKey(p => p.PessoaId);
            
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);


            // Alterando Property
            Property(p => p.Apelido)
                //.IsRequired()
                .HasMaxLength(200);

            this.ToTable("TBL_PESSOA");
            this.Property(p => p.PessoaId).HasColumnName("ID");
            this.Property(p => p.Teste).HasColumnName("STR_TESTE");
            this.Property(p => p.Idade).HasColumnName("INT_IDADE");
            this.Property(p => p.Apelido).HasColumnName("STR_APELIDO");
            this.Property(p => p.Nome).HasColumnName("STR_NOME");
            this.Property(p => p.Ativo).HasColumnName("BOOL_ATIVO");
            this.Property(p => p.DataCadastro).HasColumnName("DATE_DATA_CADASTRO");
        }
    }
}
