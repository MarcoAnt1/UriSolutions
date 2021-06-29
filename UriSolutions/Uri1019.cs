using System;

namespace UriSolutions
{
    /// <summary>
    /// Conversão de Tempo.
    /// </summary>
    public class Uri1019
    {
        public void Solution()
        {
            int segundos = int.Parse(Console.ReadLine());

            int hh = segundos / 3600;
            int mm = (segundos - (hh * 3600)) / 60;
            int ss = segundos % 60;

            Console.WriteLine($"{hh}:{mm}:{ss}");
            Console.ReadLine();
        }

        public string SolutionForTests(int segundos)
        {
            int hh = segundos / 3600;
            int mm = (segundos - (hh * 3600)) / 60;
            int ss = segundos % 60;

            return $"{hh}:{mm}:{ss}";
        }
    }
}
