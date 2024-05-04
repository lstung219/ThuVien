using System.Collections.Generic;
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

        public List<Sach> GetAllBooks()
        {
            return sachDAL.GetAllBooks();
        }
    }
}
