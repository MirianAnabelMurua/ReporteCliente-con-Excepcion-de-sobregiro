using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = { 1, 2, 3, 4, 5, 6, 7, 8 };
            try
            {

                for (int i = 0; true; i++)
                {
                    Console.WriteLine("vec[" + i + "] es '" + vec[i] + "'");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Se produjo la excepción IndexOutOfRangeException"
                                + "\nEl programa finalizó por esta causa");
            }
            Console.ReadKey();
        }
    }
}
