using System;
using main.Geradores;

namespace main
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Id = Guid.NewGuid();

            this.Nome = GeradorDeNome.GerarAsync().Result;
            
            this.DataNascimento = GeradorDeDataDeNascimento.GerarAsync().Result;
            
            this.Cpf = GeradorDeCpf.GerarAsync().Result;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime  DataNascimento { get; private set; }
        public Cpf Cpf { get; private set; }
    }
}