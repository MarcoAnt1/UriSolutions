using System;

namespace UriSolutions
{
    /// <summary>
    /// Esfera.
    /// </summary>
    public class Uri1011
    {
        public void Solution()
        {
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = (4 / 3.0) * Constants.Pi * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {volume:0.000}");
            Console.ReadLine();
        }

        public string SolutionForTests(double raio)
        {
            double volume = (4 / 3.0) * Constants.Pi * Math.Pow(raio, 3);

            return $"{volume:0.000}";
        }
    }
}
