using System;
using System.Collections.Generic;

namespace UriSolutions
{
    /// <summary>
    /// Salário.
    /// </summary>
    public class Uri1008
    {
        public void Solution()
        {
            int number = int.Parse(Console.ReadLine());
            int hourTrabalhada = int.Parse(Console.ReadLine());
            double valorRecebido = Convert.ToDouble(Console.ReadLine());

            double salary = hourTrabalhada * valorRecebido;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary:0.00}");
            Console.ReadLine();
        }

        public Dictionary<int, string> SolutionForTests(int number, int hourTrabalhada, double valorRecebido)
        {
            double salary = hourTrabalhada * valorRecebido;

            var retorno = new Dictionary<int, string>
            {
                { number, $"{salary:0.00}" }
            };

            return retorno;
        }
    }
}
