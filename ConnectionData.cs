using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFaceRec
{
    class ConnectionData
    {
        static string stcon = @"Data Source=LAPTOP-NB6QS2RK\SQLEXPRESS;Initial Catalog=attt;Integrated Security=True";
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataAdapter adp;

        public ConnectionData()
        {
            conn = new SqlConnection(stcon);
            cmd = conn.CreateCommand();
        }
        public bool ExcuteNonQuerry(string sqlstr, CommandType ct, params SqlParameter[] p)
        {
            conn.Open();
            bool f = false;
            cmd.CommandText = sqlstr;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter i in p)
                cmd.Parameters.Add(i);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException e)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public User getInfo(string username)
        {
            User u = new User();
            conn.Open();
            cmd.CommandText = "select * from users where username = " + "'" + username + "'";
            cmd.CommandType = CommandType.Text;
            var read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    u.id = read.GetInt32(0).ToString();
                    u.firstname = (string)read["firstname"];
                    u.lastname = read["lastname"].ToString();
                    u.username = read["username"].ToString();
                    u.password = read["password"].ToString();
                }
            }
            
            return u;
        }

        public bool CheckUser(string sqlstr, CommandType ct, ref string err)
        {
            conn.Open();
            bool f = false;
            cmd.CommandText = sqlstr;
            cmd.CommandType = ct;
            try
            {
                var user = cmd.ExecuteReader();
                if (user.HasRows)
                    f = true;
                else
                    f = false;
            }
            catch (SqlException e)
            {
                err += e.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public String getusername(String username)
        {
            String firstname = null;
            conn.Open();
            cmd.CommandText = "select firstname from users where username = " + "'" + username + "'";
            cmd.CommandType = CommandType.Text;
            var read = cmd.ExecuteReader();
            if(read.HasRows)
            {
                while(read.Read())
                {
                    firstname = read.GetString(0);
                }
            }
            return firstname;
        }

        public DataSet ExcuteDataSet(string sqlstr, CommandType ct)
        {
            DataSet ds = new DataSet();
            cmd.CommandText = sqlstr;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds;
        }

    }
}
