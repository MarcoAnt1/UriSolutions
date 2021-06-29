using System;

namespace UriSolutions
{
    /// <summary>
    /// Média 2.
    /// </summary>
    public class Uri1006
    {
        private readonly int pesoA = 2;
        private readonly int pesoB = 3;
        private readonly int pesoC = 5;

        public void Solution()
        {
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            double media = (a * pesoA) + (b * pesoB) + (c * pesoC);
            media /= (pesoA + pesoB + pesoC); ;

            Console.WriteLine($"MEDIA = {media:0.0}");
            Console.ReadLine();
        }

        public string SolutionForTests(double a, double b, double c)
        {
            double media = (a * pesoA) + (b * pesoB) + (c * pesoC);
            media /= (pesoA + pesoB + pesoC); ;

            return $"{media:0.0}";
        }
    }
}
