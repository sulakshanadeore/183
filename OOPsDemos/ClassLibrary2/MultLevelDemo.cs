using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    internal class SchoolStudent
    {
        int rollno;
        string name;
        string city;
        public virtual void AcceptDetails()
        {
            //writeline-readline
        }

        public virtual void DisplayDetails()
        {

        }
    }

    internal class GraduateStudent:SchoolStudent
    {
        int boardmarks;
        string streamname;
        string PRN;
        public override void AcceptDetails()
        {
            base.AcceptDetails();
            //readline & writeline for boardmarks,streamname,PRN
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            //write boardmarks,streamname,PRN
        }

    }

    sealed class DegreeStudent:GraduateStudent
    {
        string degreename;
        int graduationmarks;

        public override void AcceptDetails()
        {
            base.AcceptDetails();
            //readline & writeline for degreename,graduationmarks
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            //write degreename,graduationmarks
        }
    }

    internal class Professional
    {
        int degreemarks;
        double salary;
        int deptno;
        string mgrname;
        string projectname;
        string loc;
        string jobprofile;

        public  void AcceptingDetails()
        {
            //base.AcceptDetails();
            //readline & writeline for int degreemarks;
            
            
            
            
        }
        //public sealed override void DisplayDetails()
        //{
        //    base.DisplayDetails();
        //    //display all details of professional
        //}


    }

    internal class AnotherJob:DegreeStudent
    {
        public  new void DisplayDetails()
        {
            base.DisplayDetails();
            //display all details of professional
        }


    }

}
