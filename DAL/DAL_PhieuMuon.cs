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
    public class DAL_PhieuMuon
    {
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

    }
}
