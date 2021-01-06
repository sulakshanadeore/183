using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DataTypesDemo
{
    /// <summary>
    ///enums named constants , first color has 0 index and so on
    /// </summary>
    enum UserChoiceColor
    {
        black,
        red,
        green,
        yellow,
        NotInRange
    }

    struct Student
    {
        int rollno;
        string studname;
        int m1, m2, total;
        public void AcceptData()
        {
            Console.WriteLine("enter rollno");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            studname = Console.ReadLine();
            Console.WriteLine("Enter m1");
            m1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter m2");
            m2 = Convert.ToInt32(Console.ReadLine());

        }

        public void displayData()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(studname);
            Console.WriteLine(total);
        }
        public void CalculateTotalMarks()
        {
            total = m1 + m2;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //UserChoiceColor.black;
            Console.WriteLine("Enter color use 0 for black, 1 for red, 2 for green and 3 for yellow");
            int ch = Convert.ToInt32(Console.ReadLine());

            UserChoiceColor c = (UserChoiceColor)ch;

            Console.WriteLine(c);

            Student student = new Student();
            student.AcceptData();
            student.CalculateTotalMarks();
            student.displayData();


            //object is the largest type in the hierarchy of datatypes
            //object o1 = 34.45d;
            object o;
            int i = 10444;
            o = i;
            //Assigning a value type to a heap based reference type --- boxing
            int getback;
            getback =(int) o;
            //If  a bigger type into smaller there is chance of losing the whole value only
            //a part of value will  go to the smaller type

            float pi = 3.14f;
            int m =(int) pi;

          //  int i=100;
          //  Int32 j=34;
          //  short p=1000;
          //  Int16 q=200;
          //  float pi=3.14f;
          //  //Single
          //  double sal=87733.34d;
          //  long? d = null;
          //  //T-- type
          //  Nullable<float> d1 = null;

          //  //DataType---Int32
          //  //Value types 
          //  //Enum & Struct---- they are stored on the statck
          //  //Only value types can be boxed--- Boxing 
          //  Console.BackgroundColor=ConsoleColor.Red;//gets/sets---property
          //Console.ForegroundColor = ConsoleColor.Blue;

          //  char initial = 'y';
                       
          //  // reference types
          //  //Everything else is reference type

          //  string name = "Kajal";

          //  Console.WriteLine("Enter number");
          //  j =Convert.ToInt32(Console.ReadLine());


          //  Console.WriteLine("enter a short number");
          //  p = Convert.ToInt16(Console.ReadLine());

          //  Console.WriteLine("Enter float value");
          //  pi = Convert.ToSingle(Console.ReadLine());

          //  Console.WriteLine("Enter your name");
          //  name = Console.ReadLine();

          //  string color;
          //  Console.WriteLine("Enter color name");
          //  color = Console.ReadLine();
          //  Console.WriteLine(color);
          //  //pe file-- portable executable--- assembly file--- it is the basic unit of deployment  
          //  //ildasm-- (il)intermediate language (d)Disassemble (asm)assembly
          //  //values are stored on stack  and address on heap 
          //  //# FF5733
          //  //mscorlib---- microsoft core runtime library
          //  Console.WriteLine(i);
          //  Console.WriteLine(sal);
          //  Console.WriteLine(d);
          //  Console.WriteLine(q);
          //  Console.WriteLine(initial);








            Console.Read();

        }
    }
}
