using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    //A class can only be internal or public
    internal class Class1
    {
        private static int i = 10;// internal to class
        private void privateMethod()
        {
            Console.WriteLine(i);
        }

        //private protected void privatinternal()
        //{
        //not available in C#
        //}

        //internal private  void privatinternal()
        //{
        //not available in C#
       //}

        protected void protectedMethod()
        {
            //If inheritance
        }
        protected internal void protectedInternal()
        {
            //inheritance+internal to project
        }

        internal static int j = 20;
        static  internal void staticinternalmethod()
        {
            //static-- ie no object + internal
        }
        internal void internalmethod()
        {
            //internal to project
        }


    }

    class Class2:Class1
    {
        //Class1 c1 = new Class1();
        
        private void M3()
        {
            //base.M2();
            //base.M4();
            base.protectedMethod();
            Class1.staticinternalmethod();
            base.internalmethod();
        }
       
    }
}
