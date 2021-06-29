using System;
using System.Collections.Generic;
using System.Text;

namespace UriSolutions
{
    /// <summary>
    /// Conversão de Tempo.
    /// </summary>
    public class Uri1020
    {
        public void Solution()
        {
            int dias = int.Parse(Console.ReadLine());

            var idade = new StringBuilder();
            idade.AppendLine($"{dias / 365} ano(s)");
            dias %= 365;

            idade.AppendLine($"{dias / 30} mes(es)");
            dias %= 30;

            idade.AppendLine($"{dias} dia(s)");

            Console.WriteLine(idade.ToString());
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
