using System;

namespace UriSolutions
{
    /// <summary>
    /// Dinstância.
    /// </summary>
    public class Uri1016
    {
        public void Solution()
        {
            int distancia = int.Parse(Console.ReadLine());

            int tempo = distancia * 2;

            Console.WriteLine($"{tempo} minutos");
            Console.ReadLine();
        }

        public int SolutionForTests(int distancia)
        {
            int tempo = distancia * 2;

            return tempo;
        }
    }
}
