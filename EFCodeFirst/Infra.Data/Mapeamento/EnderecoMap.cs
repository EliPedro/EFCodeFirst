using System.Data.Entity.ModelConfiguration;
using EFCodeFirst.Dominio.Entidades;

namespace Infra.Data.Mapeamento
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {

            HasKey(e => e.EnderecoId);

            Property(e => e.Rua)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(10);

            this.ToTable("TBL_ENDERECO");
            this.Property(e => e.EnderecoId).HasColumnName("ID_ENDERECO");
            this.Property(e => e.Numero).HasColumnName("STR_NUMERO");
            this.Property(e => e.Rua).HasColumnName("STR_RUA");
            this.Property(e => e.PessoaId).HasColumnName("PESSOA_ID");

            this.HasRequired(e => e.Pessoa)
                .WithMany(e => e.Endereco)
                .HasForeignKey(e => e.PessoaId);
            
        }
    }
}
