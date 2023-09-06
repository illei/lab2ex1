using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            int x = int.Parse(Console.ReadLine());
            while (x != 0)
            {


                ;
                Console.WriteLine("\n");


                suma = suma + x % 10;

                x = x / 10;


            }


            Console.WriteLine("suma este " + suma);
        }
    }
}
