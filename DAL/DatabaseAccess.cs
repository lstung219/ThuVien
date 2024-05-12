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
        public static bool CheckEmailExists(User user)
        {
            if (string.IsNullOrEmpty(user.GMAIL))
            {
                return false;
            }

            bool exists = false;

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 1 FROM USERR WHERE GMAIL = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", user.GMAIL);

                SqlDataReader rdr = cmd.ExecuteReader();
                exists = rdr.HasRows;
            }

            return exists;
        }



        public static void UpdatePassword(User user, string newPassword)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE USERR SET PASSWORD = @Password WHERE GMAIL = @Email", conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@Email", user.GMAIL);
                cmd.ExecuteNonQuery();
            }
        }
        public bool ChangePassword(User user, string newPassword)
        {
            bool success = false;
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                string query = "UPDATE USERR SET PASSWORD = @NewPassword WHERE PASSWORD = @pass";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@pass", user.PASSWORD);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        success = true;
                }
                catch (SqlException ex)
                {
                    // Xử lý exception
                }
            }
            return success;
        }


    }
}

