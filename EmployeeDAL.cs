using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
    public class EmployeeDAL
    {
        
        public void InsertEmployee(EmployeesBAL emp)
        {
            SqlDataAdapter da;
            DataSet ds;
            PopulateData(out da, out ds);
            DataRow drow = ds.Tables["employees"].NewRow();
            drow["LastName"] = emp.LastName;
            drow["FirstName"] = emp.FirstName;
            drow["Title"] = emp.Title;
            drow["TitleOfCourtesy"] = emp.TitleOfCourtesy;

            ds.Tables["employees"].Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds, "employees");


        }

        private static void PopulateData(out SqlDataAdapter da, out DataSet ds)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWcnString"].ConnectionString);

            da = new SqlDataAdapter("select * from employees", cn);
            ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "employees");
        }

        //private static void PopulateData(out SqlDataAdapter da, out DataSet ds)
        //{


        //}

        public void UpdateEmployee(EmployeesBAL emp)
        {
            SqlDataAdapter da;
            DataSet ds;
            PopulateData(out da, out ds);

            DataRow found=ds.Tables["employees"].Rows.Find(emp.EmployeeID);
            found["FirstName"] = emp.FirstName;
            found["LastName"] = emp.LastName;
            found["Title"] = emp.Title;
            found["TitleOfCourtesy"] = emp.TitleOfCourtesy;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds, "employees");




        }

        public void DeleteEmployee(int empid)
        {
            SqlDataAdapter da;
            DataSet ds;
            PopulateData(out da, out ds);
            //DataRow found = ds.Tables["employees"].Rows.Find(empid);
            //found.Delete();

            ds.Tables["employees"].Rows.Find(empid).Delete();


            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds, "employees");






        }

        public void createFile()
        {
            DataSet ds = ShowData();

            ds.WriteXml("abc.xml");
            ds.WriteXmlSchema("abcd.xsd");

        }



        public DataTable EmployeeDataTable()
        {

            DataSet ds = ShowData();
            
            return ds.Tables["employees"];
        }


        public List<EmployeesBAL> showEmpList()
        {
            DataSet ds = ShowData();
            List<EmployeesBAL> list = new List<EmployeesBAL>();
            int cnt = ds.Tables["employees"].Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                EmployeesBAL emp = new EmployeesBAL();

                DataRow drow_i = ds.Tables["employees"].Rows[i];
                emp.EmployeeID = Convert.ToInt32(drow_i["EmployeeID"]);
                emp.FirstName = drow_i["FirstName"].ToString();
                emp.LastName = drow_i["LastName"].ToString();
                emp.Title = drow_i["Title"].ToString();
                emp.TitleOfCourtesy = drow_i["TitleOfCourtesy"].ToString();
                list.Add(emp);


            }
            return list;
        }

        private static DataSet ShowData()
        {
            SqlDataAdapter da;
            DataSet ds;
            //DataSet ds = PopulateData();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWcnString"].ConnectionString);

            da = new SqlDataAdapter("select * from employees", cn);
            ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "employees");

            SqlDataAdapter da1 = new SqlDataAdapter("select * from categories", cn);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.Fill(ds, "categories");



            return ds;
        }



        public EmployeesBAL FindEmployee(int empid)
        {
            SqlDataAdapter da;
            DataSet ds;
            PopulateData(out da, out ds);
            DataRow drow=ds.Tables["employees"].Rows.Find(empid);

            EmployeesBAL emp = new EmployeesBAL();
            emp.EmployeeID =Convert.ToInt32(drow["EmployeeID"]);
            emp.FirstName = drow["FirstName"].ToString();
            emp.LastName = drow["LastName"].ToString();
            emp.Title= drow["Title"].ToString();
            emp.TitleOfCourtesy = drow["TitleOfCourtesy"].ToString();
            return emp;


        }

    }
}
