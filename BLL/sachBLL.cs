using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class SachBLL
    {
        private SachDAL sachDAL;

        public SachBLL()
        {
            sachDAL = new SachDAL();
        }

        public List<SachMuonNhieuNhat> GetBooksMostBorrowedFromDAL()
        {
            return sachDAL.GetBooksMostBorrowed();
        }
        public List<Docgiamuonsach> GetAllDocgiamuonsach()
        {
            return sachDAL.GetAllDocgiamuonsach();
        }
        public List<Sach> GetAllBooksFromDAL()
        {
            return sachDAL.GetAllBooks();
        }

        public DataTable timsach(string tensach)
        {
            return sachDAL.timsach(tensach);
        }
        public bool them(string masach, string tensach, string tacgia, string nxb, int nam, string theloai, string ngonngu, int soluong)
        {
            return sachDAL.them(masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong);
        }
        public bool sua(string masach, string tensach, string tacgia, string nxb, int nam, string theloai, string ngonngu, int soluong)
        {
            return sachDAL.sua(masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong);
        }
        public bool xoa(string masach)
        {
            return sachDAL.xoa(masach);
        }
        
    }
}
