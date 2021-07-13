using System;

namespace UriSolutions
{
    /// <summary>
    /// Área do Círculo.
    /// </summary>
    public class Uri1002
    {
        public void Solution()
        {
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = Constants.Pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area:0.0000}");
        }

        public string SolutionForTests(double raio)
        {
            double area = Constants.Pi * Math.Pow(raio, 2);

            return $"{area:0.0000}";
        }
    }
}
