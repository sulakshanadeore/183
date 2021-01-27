using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace LINQToXMLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    SqlConnection cn = new SqlConnection
            //        ("Data Source=spd\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
            //    SqlDataAdapter da = new SqlDataAdapter("Select * from employees", cn);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    ds.WriteXml(@"D:\Sulakshana\Mphasis183\C#Demos\LINQToXMLDemo\LINQToXMLDemo\employees.xml");
            //    ds.WriteXmlSchema(@"D:\Sulakshana\Mphasis183\C#Demos\LINQToXMLDemo\LINQToXMLDemo\empschema.xml");

            //XDocument doc=XDocument.Load(@"D:\Sulakshana\Mphasis183\C#Demos\LINQToXMLDemo\LINQToXMLDemo\employees.xml");
            //IEnumerable<XElement> elements=doc.Elements();

           XElement elements= XElement.Load(@"D:\Sulakshana\Mphasis183\C#Demos\LINQToXMLDemo\LINQToXMLDemo\employees.xml");
            //IEnumerable<XElement> data = elements.Elements();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Element("EmployeeID").Value);
            //    Console.WriteLine(item.Element("LastName").Value);

            //}




            //var citydata = from d in elements.Elements("Table")
            //                where (string)d.Element("City") == "Seattle"
            //                select d;

            //foreach (var item in citydata)
            //{
            //    Console.WriteLine(item.Element("EmployeeID").Value);
            //    Console.WriteLine(item.Element("LastName").Value);
            //    Console.WriteLine(item.Element("FirstName").Value);
            //    Console.WriteLine("------------");
            //}


            //var homePhone = from phoneno in xelement.Elements("Employee")
            //                where (string)phoneno.Element("Phone").Attribute("Type") == "Home"
            //                select phoneno;



            var monthdata = (from d in elements.Elements("Table")
                             where (string)d.Element("BirthDate").Attribute("month") == "September"
                             select d).ToList().Distinct();

            foreach (var item in monthdata)
        {
                Console.WriteLine(item.Element("EmployeeID").Value);
                Console.WriteLine(item.Element("LastName").Value);
                Console.WriteLine(item.Element("FirstName").Value);
                Console.WriteLine(item.Element("BirthDate").Value);
                Console.WriteLine("------------");
            }


            //XElement elements = XElement.Load(@"D:\Sulakshana\Mphasis183\C#Demos\LINQToXMLDemo\LINQToXMLDemo\employees.xml");
            //IEnumerable<XElement> data=elements.Elements();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Element("LastName").Value);
            //}
            Console.Read();
        }
    }
}
