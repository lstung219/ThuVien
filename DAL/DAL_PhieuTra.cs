using Demo3Layer.DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuTra
    {
        private SqlConnection conn;
        public DAL_PhieuTra()
        {
            string strcon = @"Data Source=SONTUNG;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            conn = new SqlConnection(strcon);
        }
        public DataTable XemTatCaPhieuTra()
        {
            var query = "select * from PHIEUTRA";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable SearchPhieuTraTheoMaDocGia(string maDocGia)
        {
            var query = $"select * from PHIEUTRA where MADG ='{maDocGia}'";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable SearchPhieuTraTheoMaPhieuMuon(string maPhieuMuon)
        {
            var query = $"select * from PHIEUTRA where MAPHIEUMUON ='{maPhieuMuon}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuTraTheoMaPhieuTra(string maPhieuTra)
        {
            var query = $"select * from PHIEUTRA where MAPHIEUTRA ='{maPhieuTra}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable XemChiTietPhieuTra(string maPhieuTra)
        {
            var query = $"select * from CHITIETPHIEUTRA where MAPHIEUTRA ='{maPhieuTra}'";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable LayDanhSachMaTaiLieuCuaPhieuMuon(string maPhieuMuon)
        {
            string strSQL = "usp_LayMaTLCuaPM";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaPhieuMuon", maPhieuMuon));

            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public DataTable LoadMaPhieuMuon()
        {
            string strSql = "usp_LoadMaPhieuMuon";
            using (SqlCommand cmd = new SqlCommand(strSql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                da.Fill(dt);
                conn.Close();

                return dt;
            }

        }
        public DataTable LayMaPhieuMuonTheoMaDG(string maDocGia)
        {
            string strSql = "usp_LayMaPhieuMuonTheoMaDG";
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);
                    conn.Close();

                    return dt;
                }
            
        }
        public string LayMaPhieuTraTiepTheo()
        {
            string maPhieuTraTiepTheo = string.Empty;
            SqlCommand cmd = new SqlCommand("usp_TimMaPhieuTraTiepTheo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaPhieuTra", SqlDbType.NVarChar, 10);
            p.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                maPhieuTraTiepTheo = p.Value.ToString();
            }
            finally
            {
                conn.Close();
            }


            return maPhieuTraTiepTheo;
        }
        public string LayMaChiTietPhieuTraTiepTheo()
        {
            string maCTPhieuTraTiepTheo = string.Empty;
            SqlCommand cmd = new SqlCommand("usp_TimMaChiTietPhieuTraTiepTheo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaCTPT", SqlDbType.NVarChar, 10);
            p.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                maCTPhieuTraTiepTheo = p.Value.ToString();
            }
            finally
            {
                conn.Close();
            }


            return maCTPhieuTraTiepTheo;
        }
        public int LaySoSachCuaPM(string maPhieuMuon)
        {
            string strSql = "usp_LaySoSachCuaPM";
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                    SqlParameter outParameter = new SqlParameter("@SoSach", SqlDbType.Int);
                    outParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outParameter);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return (int)outParameter.Value;
                }
        }
        public int LaySoNgayQuaHan(string maPhieuMuon)
        {
            string strSql = "usp_LaySoNgayQuaHan";

                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                    SqlParameter outParameter = new SqlParameter("@NQH", SqlDbType.Int);
                    outParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outParameter);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return (int)outParameter.Value;
                }
        }
        public void TangSoLanViPham(string maDocGia)
        {
            string strSql = "usp_TangSoLanViPham";

                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            
        }
        public string LayMaDocGiaDePhat(string maPhieuMuon)
        {
            string maDocGia = string.Empty;
            string strSql = "usp_LayMaDocGiaDePhat";
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                    SqlParameter outParameter = new SqlParameter("@MaDocGia", SqlDbType.NChar, 10)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParameter);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    maDocGia = outParameter.Value.ToString().Trim();
                    conn.Close();
                }
            return maDocGia;
        }
        public void ThemPhieuTra(string MaQT,string maphieumuon,string maphieutra,string mactpt,string masach)
        {
            string strSql = "usp_ThemPhieuTra";
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuTra", maphieutra);
                    cmd.Parameters.AddWithValue("@MaNVLapPhieuTra", MaQT);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            
        }

        public void ThemChiTietPhieuTra(string MaQT,string maphieumuon,string maphieutra,string mactpt,string masach)
        {
            string strSql = "usp_ThemChiTietPhieuTra";
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCTPT", mactpt);
                    cmd.Parameters.AddWithValue("@MaPhieuTra", maphieutra);
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", maphieumuon);
                    cmd.Parameters.AddWithValue("@MaSach", masach);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            
        }




    }
}
