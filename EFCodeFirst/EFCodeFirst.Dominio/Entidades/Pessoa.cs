using System;
using System.Collections.Generic;

namespace EFCodeFirst.Dominio.Entidades
{
    
    public class Pessoa
    {
        public Pessoa()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int PessoaId { get; set; }
        
        public  string Teste { get; set; }

        // Novo campo
        public  string Apelido { get; set; }

        public string Nome { get; set; }

        public int? Idade { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
