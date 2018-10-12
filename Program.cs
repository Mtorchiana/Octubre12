using System;
using System.Collections.Generic;
using Classes;

namespace Areasfiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radio del circulo: ");
            Circulo c = new Circulo(int.Parse(Console.ReadLine()));
            Console.WriteLine("El área es: " + c.getArea());
            Console.WriteLine("Ingrese la base del rectángulo: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo: ");
            int a = int.Parse(Console.ReadLine());
            Rectangulo r = new Rectangulo(b,a);
            Console.WriteLine("El area es: " + r.getArea());


            
        }
    }
}
