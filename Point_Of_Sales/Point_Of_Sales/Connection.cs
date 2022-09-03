using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Point_Of_Sales
{
    class Connection
    {

        public static int EMP_ID = 0;

        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        string query;

        public Connection()
        {
            Open();
        }

        private void Open()
        {
            string connectiontring = "Data Source=146.230.177.46;Initial Catalog=GroupWst26;Persist Security Info=True;User ID=GroupWst26;Password=5aer2";
            con = new SqlConnection(connectiontring);
        }

        public Boolean LogIn(string username, string password)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT COUNT(1) AS EXP FROM Employee WHERE email = '" + username.Trim() + "' AND emp_password = '" + password.Trim() + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int count = int.Parse(dt.Rows[0]["EXP"].ToString());
                bool val = (count == 1);
                if(val)
                    getEmployeeID(username);
                return val; //Change this to => return val;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Employee

        public void getEmployeeID(string email)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            query = "SELECT emp_id from Employee WHERE email='" + email + "'";
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            EMP_ID = int.Parse(dt.Rows[0]["emp_id"].ToString());
            con.Close();
        }

        public bool checkEmpEmail(string email)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT COUNT(1) AS count FROM Employee WHERE email='" + email + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows[0].Field<int>("count") > 0)
                    return false;
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool checkEmpPhone(String phone)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT COUNT(1) AS count FROM Employee WHERE phone='" + phone + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows[0].Field<int>("count") > 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Customer

        public bool checkCustEmail(string email)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT COUNT(1) AS count FROM Customer WHERE email='" + email + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows[0].Field<int>("count") > 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool checkCustPhone(String phone)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT COUNT(1) AS count FROM Customer WHERE phone='" + phone + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows[0].Field<int>("count") > 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Sale

        public int getSaleID()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            query = "SELECT sale_id FROM Sales";
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            int id = int.Parse(dt.Rows[dt.Rows.Count - 1]["sale_id"].ToString());
            con.Close();
            return id;
        }

        public void updateProduct(int prod_id, int quantity)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            query = "SELECT quantity FROM Products WHERE prod_id='" + prod_id + "'";
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            int new_quantity = int.Parse(dt.Rows[0]["quantity"].ToString()) - quantity;

            query = "UPDATE Products SET quantity = @q WHERE prod_id = @id";
            com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@q", new_quantity);
            com.Parameters.AddWithValue("id", prod_id);
            int res = com.ExecuteNonQuery();
            con.Close();
        }

        public List<String> salesMoreDetails(int cust, int emp)
        {
            try
            {
                List<String> details = new List<string>();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT fname, lname, email FROM Customer WHERE cust_id='" + cust + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                details.Add(dt.Rows[0]["fname"].ToString() + " " + dt.Rows[0]["lname"].ToString());
                details.Add(dt.Rows[0]["email"].ToString());

                query = "SELECT fname, lname, email FROM EMployee WHERE emp_id='" + emp + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                details.Add(dt.Rows[0]["fname"].ToString() + " " + dt.Rows[0]["lname"].ToString());
                details.Add(dt.Rows[0]["email"].ToString());
                con.Close();
                return details;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Payments

        public decimal getTotalPayments(DateTime date)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT total FROM Payments WHERE pay_date='" + date + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    return 0;
                decimal total = 0;
                foreach(DataRow row in dt.Rows)
                {
                    total += row.Field<decimal>("total");
                }
                con.Close();
                return total;
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //Product

        public List<String> getProductInfo(int prod_id)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                query = "SELECT * FROM Products WHERE prod_id='" + prod_id + "'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count <= 0)
                    return null;
                List<String> det = new List<string>();
                det.Add(dt.Rows[0]["prod_name"].ToString());
                det.Add(dt.Rows[0]["price"].ToString());
                det.Add(dt.Rows[0]["quantity"].ToString());
                det.Add(dt.Rows[0]["category"].ToString());
                det.Add(dt.Rows[0]["description"].ToString());
                return det;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
