using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Int32 j = 34;
            short p = 1000;
            Int16 q = 200;
            float pi = 3.14f;
            //Single
            double sal = 87733.34d;
            long d = 23423666;

            //DataType---Int32
            //Value types 
            //Enum & Struct---- they are stored on the statck
            //Only value types can be boxed--- Boxing 
            Console.BackgroundColor = ConsoleColor.Red;//gets/sets---property
            Console.ForegroundColor = ConsoleColor.Blue;

            char initial = 'y';

            // reference types
            //Everything else is reference type

            string name = "Kajal";

            Console.WriteLine("Enter number");
            j = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter a short number");
            p = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter float value");
            pi = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            string color;
            Console.WriteLine("Enter color name");
            color = Console.ReadLine();
            Console.WriteLine(color);
            //pe file-- portable executable--- assembly file--- it is the basic unit of deployment  
            //ildasm-- (il)intermediate language (d)Disassemble (asm)assembly
            //values are stored on stack  and address on heap 
            //# FF5733
            //mscorlib---- microsoft core runtime library
            Console.WriteLine(i);
            Console.WriteLine(sal);
            Console.WriteLine(d);
            Console.WriteLine(q);
            Console.WriteLine(initial);

            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine(c);






            Console.Read();

        }
    }
}
