using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTra
    {
        private string maphieumuon;
        private string mactpt;
        private string masach;

        public DTO_PhieuTra(string maQT, string maphieumuon, string maphieutra, string mactpt, string masach)
        {
            MAQT = maQT;
            this.maphieumuon = maphieumuon;
            MAPHIEUTRA = maphieutra;
            this.mactpt = mactpt;
            this.masach = masach;
        }

        public string MAPHIEUTRA { get; set; }
        public DateTime NGAYLAPPHIEUTRA { get; set; }
        public string MADG { get; set; }
        public string MAQT { get; set; }
    }
}
