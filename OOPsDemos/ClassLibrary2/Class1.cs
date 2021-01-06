using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    public class PaymentModes
    {
        //Overloading---- happens in the same class/scope
        //Same method name -- but number of parameters,sequence of parameters and type of parameters is different
        public void Pay(int amt)
        {
        }
        public void Pay(int amt, string UpiId)
        {

        }
        public void Pay(string UpiId, int amt)
        {

        }

        public void Pay(string details, int phonenumber, string details1)
        {

        }
        public  void Pay(int amt, string phonenumber, string details)
        {


        }

        public  virtual void SendPaymentDetails()
        {


        }


    }


    public class Customer : PaymentModes
    {
        //override
        //public override void SendPaymentDetails()
        //{
        //   //reuse existing + extra functionality
        //}

        public  void SendPaymentDetails()
        {
            //No code reusability of the base class totally new implementation

        }

        //override
        public new void Pay(int amt, string phonenumber, string details)
        {


        }


    }
}
