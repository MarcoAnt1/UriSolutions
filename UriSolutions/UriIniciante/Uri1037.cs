using System;
using System.Collections.Generic;

namespace UriSolutions
{
    /// <summary>
    /// Fórmula de Bhaskara.
    /// </summary>
    public class Uri1037
    {
        public void Solution()
        {
            double valor = Convert.ToDouble(Console.ReadLine());

            string result = string.Empty;

            if (valor < 0 || valor > 100)
            {
                result = "Fora de intervalo";
            }
            else if (valor >= 0 && valor <= 25.00)
            {
                result = "Intervalo [0,25]";
            }
            else if (valor >= 25.01 && valor <= 50.00)
            {
                result = "Intervalo (25,50]";
            }
            else if (valor >= 50.01 && valor <= 75.00)
            {
                result = "Intervalo [50,75]";
            }
            else if (valor >= 75.01 && valor <= 100.00)
            {
                result = "Intervalo (75,100]";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public string SolutionForTests(double valor)
        {
            string result = string.Empty;

            if (valor < 0 || valor > 100)
                result = "Fora de intervalo";
            else if (valor >= 0 && valor <= 25.00)
                result = "Intervalo [0,25]";
            else if (valor >= 25.01 && valor <= 50.00)
                result = "Intervalo [25,50]";
            else if (valor >= 50.01 && valor <= 75.00)
                result = "Intervalo [70,75]";
            else if (valor >= 75.01 && valor <= 100.00)
                result = "Intervalo [75,100]";

            return result;
        }
    }
}
