using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    public class CalculadoraSimples
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
        }

        public void RaizQuadrada(int x)
        {
            Console.WriteLine($"{x}^(1/2) = {Math.Sqrt(x)}");
        }
    }
}