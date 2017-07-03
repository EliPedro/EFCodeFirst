namespace EFCodeFirst.Dominio.Entidades
{
    public  class Endereco
    {
        
        public int EnderecoId { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
