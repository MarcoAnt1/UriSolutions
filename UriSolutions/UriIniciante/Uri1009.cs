using System;
using System.Collections.Generic;

namespace UriSolutions
{
    /// <summary>
    /// Salário com Bônus.
    /// </summary>
    public class Uri1009
    {
        private readonly double comissao = 0.15;

        public void Solution()
        {
            string nome = Console.ReadLine();
            double salarioFixo = Convert.ToDouble(Console.ReadLine());
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            var salarioTotal = (totalVendas * comissao) + salarioFixo;

            Console.WriteLine($"TOTAL = R$ {salarioTotal:0.00}");
            Console.ReadLine();
        }

        public Dictionary<string, string> SolutionForTests(string nome, double salarioFixo, double totalVendas)
        {
            var salarioTotal = (totalVendas * comissao) + salarioFixo;
            salarioTotal = Math.Round(salarioTotal, 2);

            var retorno = new Dictionary<string, string>
            {
                { nome, $"{salarioTotal:0.00}" }
            };

            return retorno;
        }
    }
}
