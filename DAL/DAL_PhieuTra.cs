using Demo3Layer.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuTra
    {
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
    }
}
