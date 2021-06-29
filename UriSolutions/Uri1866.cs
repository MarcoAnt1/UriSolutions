using System;
using System.Collections.Generic;
using System.Text;

namespace UriSolutions
{
    /// <summary>
    /// Conta.
    /// </summary>
    public class Uri1866
    {
        public void Solution()
        {
            string entrada = Console.ReadLine();

            string[] casos = entrada.Split(' ');
            int quantidadeCasos = int.Parse(casos[0]);
            
            var result = new StringBuilder();

            for (int i = 1; i <= quantidadeCasos; i++)
            {
                var soma = 1;
                var negativo = true;

                for (int j = 0; j <= int.Parse(casos[i]); j++)
                {
                    if (negativo)
                    {
                        soma -= 1;
                        negativo = false;
                    }
                    else
                    {
                        soma += 1;
                        negativo = true;
                    }
                }

                result.AppendLine($"{soma}");
            }

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public List<int> SolutionForTests(string entrada)
        {
            string[] casos = entrada.Split(' ');
            int quantidadeCasos = int.Parse(casos[0]);

            var result = new List<int>();

            for (int i = 1; i <= quantidadeCasos; i++)
            {
                var soma = 1;
                var negativo = true;

                for (int j = 0; j <= int.Parse(casos[i]); j++)
                {
                    if (negativo)
                    {
                        soma -= 1;
                        negativo = false;
                    }
                    else
                    {
                        soma += 1;
                        negativo = true;
                    }
                }

                result.Add(soma);
            }

            return result;
        }
    }
}
