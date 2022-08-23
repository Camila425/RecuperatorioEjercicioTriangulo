using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRectangulo.Entidades
{
    public  class Triangulo
    {
        public static int LadoA { get; set; }
        public static int LadoB { get; set; }
        public static int LadoC { get; set; }
        public  Triangulo(int ladoa,int ladob,int ladoc)
        {
            LadoA = ladoa;
            LadoB = ladob;
            LadoC = ladoc;
        }
        
        public static bool Validar()
        {
            return LadoA + LadoB > LadoC && LadoA + LadoC > LadoB && LadoB + LadoC > LadoA;       
        }
        public string GetTriangulo()
        {
            string Resultado = "";
            if (Math.Pow(LadoA,2)==Math.Pow(LadoB,2)+Math.Pow(LadoC,2))
            {
                Resultado = "Se forma un triángulo rectángulo";
            }
            else if (Math.Pow(LadoA, 2) > Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2))
            {
                Resultado = "Se forma un triángulo obtusángulo";
            }
            else if (Math.Pow(LadoA, 2) < Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2))
            {
                Resultado = "Se forma un triángulo acutángulo";
            }
            return Resultado;
        }
        public static double GetPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public static double GetSemiPerimetro()
        {
            return (LadoA + LadoB + LadoC) / 2;
        }
        public static double GetSuperficie()
        {
            return Math.Sqrt(GetSemiPerimetro() * (GetSemiPerimetro() - LadoA) * (GetSemiPerimetro() - LadoB) * (GetSemiPerimetro() - LadoC));
        }
    }
}
