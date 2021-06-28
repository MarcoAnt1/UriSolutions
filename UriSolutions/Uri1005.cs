using System;

namespace UriSolutions
{
    /// <summary>
    /// Média 1.
    /// </summary>
    public static class Uri1005
    {
        public static void Solution()
        {
            double pesoA = 3.5;
            double pesoB = 7.5;

            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            double media = (a * pesoA) + (b * pesoB) / (pesoA + pesoB);

            Console.WriteLine($"MEDIA = {media:0.0000}");

        }
    }
}
