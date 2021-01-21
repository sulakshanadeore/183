using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using System.Data;
namespace DAL
{
    public class EmployeeDAL
    {
        public void InsertEmployee(EmployeesBAL bal)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWcnString"].ConnectionString);

            

            SqlCommand cmd = new SqlCommand("sp_InsertEmployee", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_lastname", bal.LastName);
            cmd.Parameters.AddWithValue("@p_firstname", bal.FirstName);
            cmd.Parameters.AddWithValue("@p_titleofcourtesy", bal.TitleOfCourtesy);
            int catid = 101;
            string catname = "New category";
            string description = "Some description";
            string insertstring = "insert into categories(categoryname,description) values(" + "'" + catname + "','" + description + "')";
            SqlCommand cmd1 = new SqlCommand(insertstring,cn);
            SqlTransaction tran = null;  

            //insert into categories (catname,catdesc) values ('cateogoryname','Some description category')
            cn.Open();
            try
            {

                tran = cn.BeginTransaction();
                cmd.Transaction = tran;
                int i = cmd.ExecuteNonQuery();//u/d
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                tran.Commit();
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw ex;

            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            


            //SqlCommand cmd = new SqlCommand("select * from employees",cn);
            ////select/insert/update/delete/functionname/procedurename


            ////SqlCommand cmd = new SqlCommand();
            ////cmd.CommandText = "select * from employees";
            ////cmd.Connection = cn;



            ////select----ExecuteReader()
            //SqlDataReader dr=cmd.ExecuteReader();
            ////dr.Read();----loop
            //dr.Read();
            //if (dr.Read())
            //{
            //    Console.WriteLine(dr["EmployeeID"].ToString() + " " + dr["LastName"].ToString() + "  " + dr["FirstName"].ToString());
            //}
            // cn.Close();
            //cn.Dispose();



        }

    }
}
