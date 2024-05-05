using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class BLL_Phieu
    {
        DAL_PhieuMuon dal_Phieu = new DAL_PhieuMuon();
        public DataTable XemTatCaPhieuMuon()
        {
            return dal_Phieu.XemTatCaPhieuMuon();
        }
        public DataTable SearchPhieuMuonTheoMaDocGia(string maDocGia)
        {
            return dal_Phieu.SearchPhieuMuonTheoMaDocGia(maDocGia);
        }


        public DataTable SearchPhieuMuonTheoMaPhieuMuon(string maPhieuMuon)
        {
            return dal_Phieu.SearchPhieuMuonTheoMaPhieuMuon(maPhieuMuon);
        }

        public DataTable XemChiTietPhieuMuon(string maPhieuMuon)
        {
            return dal_Phieu.XemChiTietPhieuMuon(maPhieuMuon);
        }
        public bool XoaPhieuMuon(string maPhieuMuon)
        {
            return dal_Phieu.XoaPhieuMuon(maPhieuMuon);
        }
        public int SoSachDangMuon(string maDocGia)
        {
            return dal_Phieu.SoSachDangMuon(maDocGia);
        }



        //Phiếu trả
        DAL_PhieuTra dal_PhieuTra = new DAL_PhieuTra();
        public DataTable XemTatCaPhieuTra()
        {
            return dal_PhieuTra.XemTatCaPhieuTra();
        }
        public DataTable SearchPhieuTraTheoMaDocGia(string maDocGia)
        {
            return dal_PhieuTra.SearchPhieuTraTheoMaDocGia(maDocGia);
        }


        public DataTable SearchPhieuTraTheoMaPhieuMuon(string maPhieuMuon)
        {
            return dal_PhieuTra.SearchPhieuTraTheoMaPhieuMuon(maPhieuMuon);
        }
        public DataTable SearchPhieuTraTheoMaPhieuTra(string maPhieuTra)
        {
            return dal_PhieuTra.SearchPhieuTraTheoMaPhieuTra(maPhieuTra);
        }
        public DataTable XemChiTietPhieuTra(string maPhieuTra)
        {
            return dal_PhieuTra.XemChiTietPhieuTra(maPhieuTra);
        }

    }

}
