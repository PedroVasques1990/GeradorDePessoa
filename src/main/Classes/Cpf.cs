using main.Geradores;

namespace main
{
    public class Cpf
    {
        internal Cpf(string numero) => this.Numero = numero;
        public string Numero { get; private set; }
    }
}
