using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProgramasRecursividad
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           String v = ("");
            int shd = 0;
            for (int i = 0; i < v.Length; i++)
            {
                char I = char.ToLower(v[i]);

                    if (I == 'a' || I == 'e' || I == 'i' || I == 'o' || I == 'u')
                {
                    shd=shd+1;

                }
            }
            Console.WriteLine("Numero de vocales: " + shd);
        }

    }
}
