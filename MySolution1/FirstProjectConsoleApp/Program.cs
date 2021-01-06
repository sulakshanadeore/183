using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathsLibrary;

namespace FirstProjectConsoleApp
{
    class Program
    {
        static void M1()
        {
            Console.WriteLine("M1 called......");
        }


        static void Main(string[] args)//entry point
        {
           Console.WriteLine("Hello, World");//printf
                                             //Class1 obj = new Class1();
                                             //obj.i
                                             //No need to create object of the class to call the member of the class we make the member static
                                             //Class1.i;
            Program.M1();

            //cw +tab 2
            Console.WriteLine();
            


          //  Class1.j;

            Console.Read();

            //Console.ReadLine();
            //Console.ReadKey();

           
        }
    }
}
