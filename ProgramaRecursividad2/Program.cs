using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaRecursividad2
{
    public class RecurcividadT2
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("EJERCICIO 2");
            int[] sec = { 458, 123, 999, 54, 781, 204 };

            int numeroConMayorSuma = 0;
            int ms = -1;

            for (int i = 0; i < sec.Length; i++)
            {
                int na = sec[i];

                int sa = sd(na);

                if (sa > ms)
                {
                    ms = sa;
                    numeroConMayorSuma = na;



                    Console.WriteLine("El entero cuya suma de dígitos es mayor es: " + numeroConMayorSuma);
                    Console.WriteLine("Suma de sus dígitos: " + ms);
                    Console.WriteLine();
                }
            }

        }
        private static int sd(int na)
        {
            na = Math.Abs(na);
            if (na == 0) return 0;
            return (na % 10) + sd(na / 10);
        }
    }
}
