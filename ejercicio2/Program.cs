using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; true; i++)
            {
                Debug.Assert(i<8, "El índice es mayor a la cantidad de elementos del vector");
                Console.WriteLine("vec[" + i + "] es '" + vec[i] + "'");
            }
            Console.ReadKey();
        }
    }
}
