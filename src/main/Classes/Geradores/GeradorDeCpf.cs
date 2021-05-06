using System;
using System.Threading.Tasks;

namespace main.Geradores
{
    internal struct GeradorDeCpf
    {
        internal static async Task<Cpf> GerarAsync()
        {
            return await Task.Run<Cpf>(() => 
            {
                int soma = 0, resto = 0;
                
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                
                Random random = new Random();

                string numero = random.Next(100000000, 999999999).ToString();

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(numero[i].ToString()) * multiplicador1[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                numero = numero + resto;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(numero[i].ToString()) * multiplicador2[i];

                resto = soma % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                numero = numero + resto;
                
                return new Cpf(numero);
            });
        }
    }
}