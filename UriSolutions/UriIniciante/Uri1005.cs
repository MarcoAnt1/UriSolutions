using System;

namespace UriSolutions
{
    /// <summary>
    /// Média 1.
    /// </summary>
    public class Uri1005
    {
        private readonly double pesoA = 3.5;
        private readonly double pesoB = 7.5;

        public void Solution()
        {
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            double media = (a * pesoA) + (b * pesoB);
            media /= (pesoA + pesoB);

            Console.WriteLine($"MEDIA = {media:0.00000}");
            Console.ReadLine();
        }

        public string SolutionForTests(double a, double b)
        {
            double media = (a * pesoA) + (b * pesoB);
            media /= (pesoA + pesoB);

            return $"{media:0.00000}";
        }
    }
}
