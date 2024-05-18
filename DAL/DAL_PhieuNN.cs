using Demo3Layer.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuNN
    {
        private SqlConnection conn;
        public DAL_PhieuNN()
        {
            string strcon = @"Data Source=SONTUNG;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            conn = new SqlConnection(strcon);
        }
        public DataTable XemPhieuNhacNho()
        {
            var query = "select * from PHIEUNHACNHO";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int XoaPhieuNhacNho(string maDocGia)
        {
            string strSql = "usp_XoaPhieuNhacNho";

                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnValue);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return (int)returnValue.Value;
                }
        }
        public void GiamSoLanViPham(string maDocGia)
        {
            string strSql = "usp_GiamSoLanViPham";

            using (SqlCommand cmd = new SqlCommand(strSql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

    }
}
