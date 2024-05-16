using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificarprimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("solisitar un numero");
            int divisibilidad = 0;
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisibilidad ++;
                }
            }
            if (divisibilidad <= 2)
            {
                Console.WriteLine("es primo  ");
            }
            else
            {
                Console.WriteLine("no es primo  ");
            }

            Console.ReadKey();
        }
    }
}
