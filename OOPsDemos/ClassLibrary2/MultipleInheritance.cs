using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    abstract class EducationClass:SchoolStudent1
    {

    }

    internal interface SchoolStudent1
    {


    }

    internal interface GraduateStudent1:SchoolStudent1
    {

    }
    class MultipleInheritance: GraduateStudent,GraduateStudent1, SchoolStudent1 
    {
    }
