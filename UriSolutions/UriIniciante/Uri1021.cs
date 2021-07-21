using System;
using System.Collections.Generic;
using System.Text;

namespace UriSolutions
{
    /// <summary>
    /// Notas e moedas.
    /// </summary>
    public class Uri1021
    {
        public void Solution()
        {
            string valor = Console.ReadLine();

            string[] value = valor.Split('.');
            int notas = int.Parse(value[0]);
            int moedas = int.Parse(value[1]);

            Console.WriteLine($"NOTAS:");

            Console.WriteLine($"{notas / 100} nota(s) de R$ 100.00");
            notas %= 100;

            Console.WriteLine($"{notas / 50} nota(s) de R$ 50.00");
            notas %= 50;

            Console.WriteLine($"{notas / 20} nota(s) de R$ 20.00");
            notas %= 20;

            Console.WriteLine($"{notas / 10} nota(s) de R$ 10.00");
            notas %= 10;

            Console.WriteLine($"{notas / 5} nota(s) de R$ 5.00");
            notas %= 5;

            Console.WriteLine($"{notas / 2} nota(s) de R$ 2.00");
            notas %= 2;

            Console.WriteLine($"MOEDAS:");

            Console.WriteLine($"{notas / 1} moeda(s) de R$ 1.00");

            Console.WriteLine($"{moedas / 50} moeda(s) de R$ 0.50");
            moedas %= 50;

            Console.WriteLine($"{moedas / 25} moeda(s) de R$ 0.25");
            moedas %= 25;

            Console.WriteLine($"{moedas / 10} moeda(s) de R$ 0.10");
            moedas %= 10;

            Console.WriteLine($"{moedas / 05} moeda(s) de R$ 0.05");
            moedas %= 05;

            Console.WriteLine($"{moedas / 01} moeda(s) de R$ 0.01");
            Console.ReadLine();
        }

        public List<string> SolutionForTests(string valor)
        {
            string[] value = valor.Split('.');
            int notas = int.Parse(value[0]);
            int moedas = int.Parse(value[1]);

            var result = new List<string>();
            result.Add($"{notas / 100} nota(s) de R$ 100.00");
            notas %= 100;

            result.Add($"{notas / 50} nota(s) de R$ 50.00");
            notas %= 50;

            result.Add($"{notas / 20} nota(s) de R$ 20.00");
            notas %= 20;

            result.Add($"{notas / 10} nota(s) de R$ 10.00");
            notas %= 10;

            result.Add($"{notas / 5} nota(s) de R$ 5.00");
            notas %= 5;

            result.Add($"{notas / 2} nota(s) de R$ 2.00");
            notas %= 2;

            result.Add($"{notas / 1} moeda(s) de R$ 1.00");

            result.Add($"{moedas / 50} moeda(s) de R$ 0.50");
            moedas %= 50;

            result.Add($"{moedas / 25} moeda(s) de R$ 0.25");
            moedas %= 25;

            result.Add($"{moedas / 10} moeda(s) de R$ 0.10");
            moedas %= 10;

            result.Add($"{moedas / 05} moeda(s) de R$ 0.05");
            moedas %= 05;

            result.Add($"{moedas / 01} moeda(s) de R$ 0.01");

            return result;
        }
    }
}
