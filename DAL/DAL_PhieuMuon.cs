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
   
    public class DAL_PhieuMuon
    {
        private SqlConnection conn;
        public DAL_PhieuMuon()
        {
            string strcon = @"Data Source=SONTUNG;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            conn = new SqlConnection(strcon);
        }
        public DataTable XemTatCaPhieuMuon()
        {
            var query = "select * from PHIEUMUON"; 
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable SearchPhieuMuonTheoMaDocGia(string maDocGia)
        {
            var query = $"select * from PHIEUMUON where MADG ='{maDocGia}'";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable SearchPhieuMuonTheoMaPhieuMuon(string maPhieuMuon)
        {
            var query = $"select * from PHIEUMUON where MAPHIEUMUON ='{maPhieuMuon}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable XemChiTietPhieuMuon(string maPhieuMuon)
        {
            var query = $"select * from CHITIETPHIEUMUON where MAPHIEUMUON ='{maPhieuMuon}'";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public bool XoaPhieuMuon(string maPhieuMuon)
        {
            try
            {
                var query = "EXEC usp_XoaPhieuMuon @MAPHIEUMUON";
                var result = DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieuMuon });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int SoSachDangMuon(string maDocGia)
        {
            var query = "EXEC usp_SoSachDangMuon @MaDocGia, @SoSachDangMuon OUT";
            SqlParameter outParameter = new SqlParameter("@SoSachDangMuon", SqlDbType.Int);
            outParameter.Direction = ParameterDirection.Output;

            DataProvider.Instance.ExecuteQuery(query, new object[] { maDocGia, outParameter });
            int soSachDangMuon = (int)outParameter.Value;

            return soSachDangMuon;
        }


        public DataTable LayDanhSachSach()
        {
            var query = "select MASACH, TENSACH FROM SACH where SLTON > 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string LayMaPhieuMuonTiepTheo()
        {
            string maPhieuMuonTiepTheo = string.Empty;
            SqlCommand cmd = new SqlCommand("usp_TimMaPhieuMuonTiepTheo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaPhieuMuon", SqlDbType.NVarChar, 10);
            p.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                maPhieuMuonTiepTheo = p.Value.ToString();
            }
            finally
            {
                conn.Close();
            }


            return maPhieuMuonTiepTheo;
        }
        public string LayMaChiTietPhieuMuonTiepTheo()
        {
            string maCTPhieuMuonTiepTheo = string.Empty;
            SqlCommand cmd = new SqlCommand("usp_TimMaChiTietPhieuMuonTiepTheo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaCTPM", SqlDbType.NVarChar, 10);
            p.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                maCTPhieuMuonTiepTheo = p.Value.ToString();
            }
            finally
            {
                conn.Close();
            }


            return maCTPhieuMuonTiepTheo;
        }
        public int ThemPhieuMuon(string maQTHienTai, string madocgia, string masach, string maphieumuon, string mactpm)
        {
            string strSql = "usp_ThemPhieuMuon";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pResult = new SqlParameter("@result", SqlDbType.Int);
            pResult.Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@MaQT", maQTHienTai);
                cmd.Parameters.AddWithValue("@MaDocGia", madocgia);
                cmd.Parameters.Add(pResult);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            return (int)pResult.Value;
        }
        public void ThemChiTietPhieuMuon(string maCTPM, string maSach, string maPhieuMuon)
        {
            string strSql = "usp_ThemChiTietPhieuMuon";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@MaCTPM", maCTPM);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
