using System;
using System.Collections.Generic;

namespace UriSolutions
{
    /// <summary>
    /// Idade em dias.
    /// </summary>
    public class Uri1020
    {
        public void Solution()
        {
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine($"{dias / 365} ano(s)");
            dias %= 365;

            Console.WriteLine($"{dias / 30} mes(es)");
            dias %= 30;

            Console.WriteLine($"{dias} dia(s)");
            Console.ReadLine();
        }

        public List<string> SolutionForTests(int dias)
        {
            var idade = new List<string>();
            idade.Add($"{dias / 365} ano(s)");
            dias %= 365;

            idade.Add($"{dias / 30} mes(es)");
            dias %= 30;

            idade.Add($"{dias} dia(s)");

            return idade;
        }
    }
}
