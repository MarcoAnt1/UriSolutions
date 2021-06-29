using System;

namespace UriSolutions
{
    /// <summary>
    /// Dinstância Entre Dois Pontos.
    /// </summary>
    public class Uri1015
    {
        public void Solution()
        {
            string texto1 = Console.ReadLine();
            string texto2 = Console.ReadLine();

            string[] value1 = texto1.Split(' ');
            double x1 = Convert.ToDouble(value1[0]);
            double y1 = Convert.ToDouble(value1[1]);

            string[] value2 = texto1.Split(' ');
            double x2 = Convert.ToDouble(value2[0]);
            double y2 = Convert.ToDouble(value2[1]);

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"{distance:0.0000}");
            Console.ReadLine();
        }

        public string SolutionForTests(string texto1, string texto2)
        {
            string[] value1 = texto1.Split(' ');
            double x1 = Convert.ToDouble(value1[0]);
            double y1 = Convert.ToDouble(value1[1]);

            string[] value2 = texto2.Split(' ');
            double x2 = Convert.ToDouble(value2[0]);
            double y2 = Convert.ToDouble(value2[1]);

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return $"{distance:0.0000}";
        }
    }
}
