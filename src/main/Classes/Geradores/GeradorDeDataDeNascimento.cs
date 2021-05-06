using System;
using System.Threading.Tasks;

namespace main.Geradores
{
    internal class GeradorDeDataDeNascimento
    {
        internal static async Task<DateTime> GerarAsync()
        {
            return await Task.Run<DateTime>( () => 
            {
                DateTime dataMinima = new DateTime(1920, 1, 1);

                int rangeDias = (DateTime.Today - dataMinima).Days;
                
                Random random = new Random();

                return dataMinima.AddDays(random.Next(rangeDias));
            });
        }
    }
}