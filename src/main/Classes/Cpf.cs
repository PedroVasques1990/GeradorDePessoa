using main.Geradores;

namespace main
{
    public struct Cpf
    {
        internal Cpf(string numero) => this.Numero = numero;
        public string Numero { get; private set; }
    }
}
