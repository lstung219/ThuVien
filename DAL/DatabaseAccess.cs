using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        // Create database connection
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=LAPTOP-HN4DH2L8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }

    public class DatabaseAccess
    {
        public static string CheckLogin(User user)
        {
            string result = null;

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT *FROM USERR WHERE USERNAME = @user AND PASSWORD = @pass", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@user", user.USERNAME);
                cmd.Parameters.AddWithValue("@pass", user.PASSWORD);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        if (rdr.Read())
                        {
                            result = rdr.GetString(0);
                        }
                    }
                    else
                    {
                        result = "Khong_dung";
                    }
                }
            }

            return result;
        }
    }
}
