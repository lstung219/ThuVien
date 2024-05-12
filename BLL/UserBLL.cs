using DTO;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        TaikhoanAccess tka = new TaikhoanAccess();
        DatabaseAccess dba = new DatabaseAccess();
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
        public bool ChangePassword(User user, string newPassword)
        {
            // Kiểm tra các điều kiện, xác thực người dùng (nếu cần)

            // Thực hiện việc thay đổi mật khẩu
            return dba.ChangePassword(user, newPassword);
        }


    }
}
