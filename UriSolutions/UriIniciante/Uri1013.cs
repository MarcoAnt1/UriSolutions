using System;

namespace UriSolutions
{
    /// <summary>
    /// O Maior.
    /// </summary>
    public class Uri1013
    {
        public void Solution()
        {
            string texto = Console.ReadLine();

            string[] value = texto.Split(' ');
            int a = int.Parse(value[0]);
            int b = int.Parse(value[1]);
            int c = int.Parse(value[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maiorC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine($"{maiorC} eh o maior");
            Console.ReadLine();
        }

        public int SolutionForTests(string texto)
        {
            string[] value = texto.Split(' ');
            int a = int.Parse(value[0]);
            int b = int.Parse(value[1]);
            int c = int.Parse(value[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maiorC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            return maiorC;
        }
    }
}
