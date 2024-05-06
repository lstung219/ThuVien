using Demo3Layer.DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SachDAL
    {
        private string connectionString = @"Data Source=LAPTOP-KSBFPQRI\LAPTOP;Initial Catalog=QLTHUVIEN;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn

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
        public DataTable timsach(string tensach)
        {
            var query = $"select * from Sach where TENSACH like N'%{tensach}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool them(string masach, string tensach, string tacgia, string nxb, int nam, string theloai, string ngonngu, int soluong)
        {
            string query = string.Format("INSERT INTO SACH VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', {7} )", masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong);
            int relsult = DataProvider.Instance.ExecuteNonQuery(query);
            return relsult > 0;
        }
        public bool sua(string masach, string tensach, string tacgia, string nxb, int nam, string theloai, string ngonngu, int soluong)
        {
            string query = string.Format("UPDATE SACH SET TENSACH= N'{1}', TACGIA= N'{2}', NHAXB= N'{3}', NXB= N'{4}', THELOAI=N'{5}', NGONNGU=N'{6}', SLTON={7} WHERE MASACH='{0}'", masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong);
            int relsult = DataProvider.Instance.ExecuteNonQuery(query);
            return relsult > 0;
        }
        public bool xoa(string masach)
        {
            string query = string.Format("DELETE FROM SACH WHERE MASACH='{0}'", masach);
            int relsult = DataProvider.Instance.ExecuteNonQuery(query);
            return relsult > 0;
        }
    }
}
