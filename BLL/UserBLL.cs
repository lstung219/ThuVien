using DTO;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        TaikhoanAccess tka = new TaikhoanAccess();

        public string Checklogin(User user)
        {
            if (user.USERNAME == "")
                return "tk_trong";
            if (user.PASSWORD == "")
                return "mk_trong";

            // Call the CheckLogin method from TaikhoanAccess to perform the actual login check
            string result = tka.Checklogin(user);

            return result;
        }
        
    }
}
