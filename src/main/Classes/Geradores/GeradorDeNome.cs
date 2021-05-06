using System;
using System.Threading.Tasks;
using main.Enums;

namespace main.Geradores
{
    internal class GeradorDeNome
    {
        internal static async Task<string> GerarAsync()
        {
            Random random = new Random();

            int indiceEnum = random.Next(Enum.GetNames(typeof(Nomes)).Length);

            return await Task.Run<string>(() => 
            {
                return ((Nomes)indiceEnum).ToString();
            });
        }
    }
}