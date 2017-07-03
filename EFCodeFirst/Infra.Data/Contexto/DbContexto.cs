using EFCodeFirst.Dominio.Entidades;
using Infra.Data.Mapeamento;

namespace Infra.Data.Contexto
{
    using System.Data.Entity;
 
    public  class DbContexto : DbContext
    {
        public DbContexto(): base("name=BancoFeioContexto")
        {
        }

        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType + "Id");

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add((new PessoaMap()));
        }
    }
}
