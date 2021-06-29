using System;
using System.Collections.Generic;
using System.Text;

namespace UriSolutions
{
    /// <summary>
    /// Área.
    /// </summary>
    public class Uri1012
    {
        public void Solution()
        {
            var texto = Console.ReadLine();

            string[] arrayTexto = texto.Split(' ');
            double A = Convert.ToDouble(arrayTexto[0]);
            double B = Convert.ToDouble(arrayTexto[1]);
            double C = Convert.ToDouble(arrayTexto[2]);

            double triangulo = (A * C) / 2;
            double circulo = Constants.Pi * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            var result = new StringBuilder();
            result.AppendLine($"TRIANGULO: {triangulo:0.000}");
            result.AppendLine($"CIRCULO: {circulo:0.000}");
            result.AppendLine($"TRAPEZIO: {trapezio:0.000}");
            result.AppendLine($"QUADRADO: {quadrado:0.000}");
            result.AppendLine($"RETANGULO: {retangulo:0.000}");

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public List<string> SolutionForTests(string texto)
        {
            string[] arrayTexto = texto.Split(' ');
            double A = Convert.ToDouble(arrayTexto[0]);
            double B = Convert.ToDouble(arrayTexto[1]);
            double C = Convert.ToDouble(arrayTexto[2]);

            double triangulo = (A * C) / 2;
            double circulo = Constants.Pi * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            var retorno = new List<string>
            {
                $"{triangulo:0.000}",
                $"{circulo:0.000}",
                $"{trapezio:0.000}",
                $"{quadrado:0.000}",
                $"{retangulo:0.000}"
            };

            return retorno;
        }
    }
}
