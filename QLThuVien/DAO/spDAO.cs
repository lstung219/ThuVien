using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.DAO
{
    public class spDAO
    {

        private static spDAO instance;

        public static spDAO Instance
        { 
                get{ if (instance == null) instance = new spDAO(); return instance; }
                private set { spDAO.instance = value; } 
        }
        private spDAO() { }

    }
}
