using System.Linq;
using Infra.Data.Contexto;
using static System.Console;

namespace EFCodeFirst.UI
{
    internal class Program
    {
        private  static void Main(string[] args)
        {

            var ctx = new DbContexto();

            var pessoa = ctx.Pessoa.Include("Endereco").FirstOrDefault(p => p.Nome == "KAROLINE");
            
             WriteLine(pessoa.Endereco.FirstOrDefault().Rua);
            
            var pessoa2 = from c in ctx.Pessoa.AsEnumerable()
                join e in ctx.Endereco
                on c.PessoaId equals e.PessoaId
                select c;

            foreach (var item in pessoa2)
            {
                WriteLine($@"Nome: {item.Nome}");
            }
                         
            
            ReadKey();
        }
    }
}
