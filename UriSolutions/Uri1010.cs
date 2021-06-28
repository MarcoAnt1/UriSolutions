using System;

namespace UriSolutions
{
    /// <summary>
    /// Salário com Bônus.
    /// </summary>
    public class Uri1010
    {
        public void Solution()
        {
            string compra1 = Console.ReadLine();
            string compra2 = Console.ReadLine();

            string[] values1 = compra1.Split(' ');
            int codPeca1 = int.Parse(values1[0]);
            int numPeca1 = int.Parse(values1[1]);
            double valorPeca1 = Convert.ToDouble(values1[2]);

            string[] values2 = compra2.Split(' ');
            int codPeca2 = int.Parse(values2[0]);
            int numPeca2 = int.Parse(values2[1]);
            double valorPeca2 = Convert.ToDouble(values2[2]);

            double valorTotal = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:0.00}");
            Console.ReadLine();
        }

        public string SolutionForTests(string compra1, string compra2)
        {
            string[] values1 = compra1.Split(' ');
            int numPeca1 = int.Parse(values1[1]);
            double valorPeca1 = Convert.ToDouble(values1[2]);

            string[] values2 = compra2.Split(' ');
            int numPeca2 = int.Parse(values2[1]);
            double valorPeca2 = Convert.ToDouble(values2[2]);

            double valorTotal = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);

            return $"{valorTotal:0.00}";
        }
    }
}
