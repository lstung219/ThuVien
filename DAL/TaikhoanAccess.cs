using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class TaikhoanAccess:DatabaseAccess
    {
        
        public string Checklogin(User user) { 
            string a=DatabaseAccess.CheckLogin(user);
            return a;
        }
        
    }
}
