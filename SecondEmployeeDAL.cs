using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using System.Data;
using System.Transactions;

namespace DAL
{
    public class SecondEmployeeDAL
    {
        public void InsertEmployee(EmployeesBAL bal)
        {
            SqlConnection cn = null;
            using (var txnScope = new TransactionScope(TransactionScopeOption.Required))
            {


                try
                {

                    cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWcnString"].ConnectionString);

                    
                    SqlCommand cmd = new SqlCommand("sp_InsertEmployee", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_lastname", bal.LastName);
                    cmd.Parameters.AddWithValue("@p_firstname", bal.FirstName);
                    cmd.Parameters.AddWithValue("@p_titleofcourtesy", bal.TitleOfCourtesy);
                   
                    string catname = "category1";
                    string description = "description1";
                    SqlCommand cmd1 = new SqlCommand("insert into categories(categoryname,description) values(" + "'" + catname + "','" + description + "')", cn);

                    cn.Open();
									   					 
                    int i = cmd.ExecuteNonQuery();//u/d

                    cmd1.ExecuteNonQuery();
                    txnScope.Complete();
                }
                catch (SqlException ex)
                {
                    txnScope.Dispose();
                    throw ex;

                }
                finally
                {
                    cn.Close();
                    cn.Dispose();
                }

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


        public List<EmployeesBAL> ShowEmp()
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWcnString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select * from ShowEmployees()",cn);
                cn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                //sqldatareader is a readonly, forward only stream of data, object cannot be created, its sealed
                List<EmployeesBAL> emplist = new List<EmployeesBAL>();
                while (dr.Read())
                {
                    EmployeesBAL emp = new EmployeesBAL();
                     emp.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                    emp.FirstName = dr["FirstName"].ToString();
                    emp.LastName = dr["LastName"].ToString();
                    emp.Title = dr["Title"].ToString();
                    emp.TitleOfCourtesy = dr["TitleOfCourtesy"].ToString();
                    emplist.Add(emp);
                }
                return emplist;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
                cn.Dispose();

            }



        }



        public List<OrdersData> ShowOrderData(int orderid)
        {
                   SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWcnString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select * from fn_Mst_ShowData(@p_orderid)", cn);
                cmd.Parameters.AddWithValue("@p_orderid", orderid);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //sqldatareader is a readonly, forward only stream of data, object cannot be created, its sealed
                List<OrdersData> orders = new List<OrdersData>();
                while (dr.Read())
                {
                    OrdersData o = new OrdersData();
                    o.Orderno = Convert.ToInt32(dr["OrderNo"]);
                    o.Prodid = Convert.ToInt32(dr["Productid"]);
                    o.ProdName = dr["ProductName"].ToString();
                    o.qty = Convert.ToInt32(dr["qty"]);
					o.unitPrice= Convert.ToInt32(dr["unitPrice"]);
					o.dis= Convert.ToInt32(dr["dis"]);
                    orders.Add(o);
                }
                return orders;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();

            }

        }




    }
}
