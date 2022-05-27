using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escribre un numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escribe otro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException a)
            {
                Console.WriteLine(a.Message);
                Console.WriteLine(a.StackTrace);
            }
            Console.ReadKey();

        }
    }
}
