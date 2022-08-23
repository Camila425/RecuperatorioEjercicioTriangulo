using EjercicioRectangulo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRectangulo.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            int ladoa=1, ladob=1, ladoc=1;
            Triangulo triangulo = new Triangulo(ladoa,ladob,ladoc);
            Console.Write("ingrese el ladoA:");
            ladoa = int.Parse(Console.ReadLine());
            Console.Write("ingrese el ladoB:");
            ladob = int.Parse(Console.ReadLine());
            Console.Write("ingrese el ladoC:");
            ladoc = int.Parse(Console.ReadLine());

            if (Triangulo.Validar())
            {
                Triangulo triangulo1 = new Triangulo(ladoa, ladob, ladoc);
                Console.WriteLine($"{triangulo1.GetTriangulo()}");
                Console.WriteLine($"perimetro:{Triangulo.GetPerimetro()}");
                Console.WriteLine($"semiperimetro:{Triangulo.GetSemiPerimetro()}");
                Console.WriteLine($"superficie:{Triangulo.GetSuperficie()}");
            }
            else
            {
                Console.WriteLine("lados mal ingresados");
            }
            Console.ReadLine();


        }
    }
}
