using System;

namespace UriSolutions
{
    /// <summary>
    /// Teste de Seleção 1.
    /// </summary>
    public class Uri1035
    {
        public void Solution()
        {
            string texto = Console.ReadLine();

            string[] value = texto.Split(' ');
            int a = int.Parse(value[0]);
            int b = int.Parse(value[1]);
            int c = int.Parse(value[2]);
            int d = int.Parse(value[3]);

            string retorno;
            if (b > c && d > a && (c + d) > (a + b) && (c > 0) && (d > 0) && (a % 2) == 0)
            {
                retorno = "Valores aceitors";
            }
            else
            {
                retorno = "Valores nao aceitos";
            }

            Console.WriteLine(retorno);
            Console.ReadLine();
        }

        public string SolutionForTests(string texto)
        {
            string[] value = texto.Split(' ');
            int a = int.Parse(value[0]);
            int b = int.Parse(value[1]);
            int c = int.Parse(value[2]);
            int d = int.Parse(value[3]);

            if (b > c && d > a && (c + d) > (a + b) && (c > 0) && (d > 0) && (a % 2) == 0)
                return "Valores aceitos";
            else
                return "Valores nao aceitos";
        }
    }
}
