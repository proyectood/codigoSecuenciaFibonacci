using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int comprobarNum, num = 1, x = 0, y = 1;
            bool comprobar;
            String limite;

            Console.WriteLine("Escriba un numero para que sirva como maximo para la secuencia: ");
            limite = Console.ReadLine();

            if (comprobar = int.TryParse(limite, out comprobarNum))
            {
                Console.Clear();
                Console.WriteLine("Secuencia fibonacci con el limite " + limite + "\r\n");
                Console.WriteLine("0");
                while (num <= Convert.ToInt32(limite))
                {
                    Console.WriteLine(num.ToString());
                    num = x + y;
                    x = y;
                    y = num;
                }
            } else
            {
                Console.Clear();
                Console.WriteLine("Lo siento, solo se admiten numeros enteros. Cerrando...");
            }
        }
    }
}
