using System;
using System.Collections.Generic;
using System.Text;

namespace UriSolutions
{
    /// <summary>
    /// Fórmula de Bhaskara.
    /// </summary>
    public class Uri1036
    {
        public void Solution()
        {
            string texto = Console.ReadLine();

            string[] value = texto.Split(' ');
            double a = Convert.ToDouble(value[0]);
            double b = Convert.ToDouble(value[1]);
            double c = Convert.ToDouble(value[2]);

            double delta = Math.Pow(b, 2) - ((4 * a) * c);
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            var result = new StringBuilder();

            if (delta < 0 || a == 0)
            {
                result.AppendLine("Impossivel calcular");
            }
            else
            {
                result.AppendLine($"R1 = {r1:0.00000}");
                result.AppendLine($"R2 = {r2:0.00000}");
            }

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public List<string> SolutionForTests(string texto)
        {
            string[] value = texto.Split(' ');
            double a = Convert.ToDouble(value[0]);
            double b = Convert.ToDouble(value[1]);
            double c = Convert.ToDouble(value[2]);

            double delta = Math.Pow(b, 2) - ((4 * a) * c);
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            var result = new List<string>();

            if (delta < 0 || a == 0)
            {
                result.Add("Impossivel calcular");
            }
            else
            {
                result.Add($"R1 = {r1:0.00000}");
                result.Add($"R2 = {r2:0.00000}");
            }

            return result;
        }
    }
}
