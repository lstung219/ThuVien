using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SachDAL
    {
        private string connectionString = @"Data Source=LAPTOP-HN4DH2L8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn

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
        public List<SachMuonNhieuNhat> GetBooksMostBorrowed()
        {
            List<SachMuonNhieuNhat> sachList = new List<SachMuonNhieuNhat>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 10 S.MASACH, S.TENSACH, COUNT(*) AS SoLuotMuon
                    FROM Sach S
                    INNER JOIN CHITIETPHIEUMUON CT ON S.MASACH = CT.MASACH
                    INNER JOIN PHIEUMUON PM ON CT.MAPHIEUMUON = PM.MAPHIEUMUON
                    GROUP BY S.MASACH, S.TENSACH
                    ORDER BY SoLuotMuon DESC";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SachMuonNhieuNhat sach = new SachMuonNhieuNhat
                    {
                        MASACH = reader["MASACH"].ToString(),
                        TENSACH = reader["TENSACH"].ToString(),
                        SoLuotMuon = Convert.ToInt32(reader["SoLuotMuon"])
                    };
                    sachList.Add(sach);
                }
                connection.Close();
            }

            return sachList;
        }
    }
}
