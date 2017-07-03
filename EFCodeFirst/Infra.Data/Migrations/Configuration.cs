using Infra.Data.Contexto;

namespace Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContexto>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;
        
        protected override void Seed(DbContexto context)
        {
        }
    }
}
