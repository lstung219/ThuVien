using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuMuon
    {
        public DTO_PhieuMuon(string maCTPM, string maTaiLieu, string maTaiLieuCu, string maPhieuMuon)
        {
            MaCTPM = maCTPM;
            MaTaiLieu = maTaiLieu;
            MaTaiLieuCu = maTaiLieuCu;
            MAPHIEUMUON = maPhieuMuon;
        }

        public string MAPHIEUMUON { get; set; }
        public DateTime NGAYLAPPHIEU { get; set; }
        public string MADG { get; set; }
        public string MAQT { get; set; }
        public string MaCTPM { get; }
        public string MaTaiLieu { get; }
        public string MaTaiLieuCu { get; }
    }
}
