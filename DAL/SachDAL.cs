using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SachDAL
    {
        private string connectionString = @"Data Source=SONTUNG;Initial Catalog=QLTHUVIEN;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn

        public List<Sach> GetAllBooks()
        {
            List<Sach> sachList = new List<Sach>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sach";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Sach sach = new Sach
                    {
                        MASACH = reader["MASACH"].ToString(),
                        TENSACH = reader["TENSACH"].ToString(),
                        TACGIA  = reader["TACGIA"].ToString(),
                        NHAXB = reader["NHAXB"].ToString(),
                        NXB = reader["NXB"].ToString(),
                        THELOAI = reader["THELOAI"].ToString(),
                        NGONNGU = reader["NGONNGU"].ToString(),
                        SLTON = reader["SLTON"].ToString()
                    };
                    sachList.Add(sach);
                }
                connection.Close();
            }

            return sachList;
        }
    }
}
