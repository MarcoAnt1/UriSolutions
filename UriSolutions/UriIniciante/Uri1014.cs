using System;

namespace UriSolutions
{
    /// <summary>
    /// Consumo.
    /// </summary>
    public class Uri1014
    {
        public void Solution()
        {
            int x = int.Parse(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double consumo = x / y;

            Console.WriteLine($"{consumo:0.000} km/l");
            Console.ReadLine();
        }

        public string SolutionForTests(int x, double y)
        {
            double consumo = x / y;

            return $"{consumo:0.000}";
        }
    }
}
