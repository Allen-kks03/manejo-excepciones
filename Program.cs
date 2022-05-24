using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;

            try
            {
                Console.Write("Dame un numero entero: ");
                Num = int.Parse(Console.ReadLine());
                Console.WriteLine("El cuadrado es: "+Math.Pow(Num, 2));
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
