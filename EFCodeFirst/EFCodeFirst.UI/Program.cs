using System;
using System.Linq;
using System.Net.Sockets;
using Infra.Data.Contexto;

namespace EFCodeFirst.UI
{
    internal class Program
    {
        private  static void Main(string[] args)
        {

            var ctx = new DbContexto();

            var pessoa = ctx.Pessoa.Include("Endereco").FirstOrDefault(p => p.Nome == "KAROLINE");

            Console.WriteLine(pessoa.Endereco.FirstOrDefault().Rua);


            var pessoa2 = from c in ctx.Pessoa.AsEnumerable()
                join e in ctx.Endereco
                on c.PessoaId equals e.PessoaId
                select c;

            foreach (var item in pessoa2)
            {
                Console.WriteLine($@"Nome: {item.Nome}");
            }
                         

                           


            Console.ReadKey();
        }
    }
}
