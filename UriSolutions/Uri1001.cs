using System;

namespace UriSolutions
{
    /// <summary>
    /// Extremamente Básico.
    /// </summary>
    public static class Uri1001
    {
        public static void Solution()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.WriteLine($"X = {x}");
        }

        public static int SolutionForTest(int a, int b)
        {
            int x = a + b;

            return x;
        }
    }
}
