using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaRecursividad3
{
    internal class Program
    {
        public static int sp(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + sp(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 3");
            int n = 5;
            int r = sp(n);
            Console.WriteLine("La suma de los primeros " + n + " números positivos es: " + r);
        }
    }
}
