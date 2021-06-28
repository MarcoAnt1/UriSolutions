using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UriSolutions
{
    public static class Uri1001
    {
        public static void Solution()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.WriteLine($"X = {x}");
        }
    }
}
