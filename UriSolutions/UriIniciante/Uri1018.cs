using System;
using System.Collections.Generic;
using System.Text;

namespace UriSolutions
{
    /// <summary>
    /// Cédulas.
    /// </summary>
    public class Uri1018
    {
        public void Solution()
        {
            var notas = int.Parse(Console.ReadLine());

            var result = new StringBuilder();
            Console.WriteLine(($"{notas}");

            Console.WriteLine(($"{notas / 100} nota(s) de R$ 100,00");
            notas %= 100;

            Console.WriteLine($"{notas / 50} nota(s) de R$ 50,00");
            notas %= 50;

            Console.WriteLine($"{notas / 20} nota(s) de R$ 20,00");
            notas %= 20;

            Console.WriteLine($"{notas / 10} nota(s) de R$ 10,00");
            notas %= 10;

            Console.WriteLine($"{notas / 5} nota(s) de R$ 5,00");
            notas %= 5;

            Console.WriteLine($"{notas / 2} nota(s) de R$ 2,00");
            notas %= 2;

            Console.WriteLine($"{notas / 1} nota(s) de R$ 1,00");

            Console.ReadLine();
        }

        public List<string> SolutionForTests(int notas)
        {
            var result = new List<string>();
            result.Add($"{notas / 100} nota(s) de R$ 100,00");
            notas %= 100;

            result.Add($"{notas / 50} nota(s) de R$ 50,00");
            notas %= 50;

            result.Add($"{notas / 20} nota(s) de R$ 20,00");
            notas %= 20;

            result.Add($"{notas / 10} nota(s) de R$ 10,00");
            notas %= 10;

            result.Add($"{notas / 5} nota(s) de R$ 5,00");
            notas %= 5;

            result.Add($"{notas / 2} nota(s) de R$ 2,00");
            notas %= 2;

            result.Add($"{notas / 1} nota(s) de R$ 1,00");

            return result;
        }
    }
}
