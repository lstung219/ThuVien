using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.DAO
{
    internal class accDAO
    {
        private static accDAO instance;

        public static accDAO Instance
        {
            get { if (instance == null) instance = new accDAO(); return instance;  }
            private set { instance = value; }
        }
        private accDAO()
        {

        }
        public bool login(string username, string password)
        {
            string query = "SELECT * FROM TAIKHOANG WHERE USERNAME= N'"+ username +"' AND PASSWORDD='"+ password +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query); 

            return result.Rows.Count  > 0;
        }
    }
}
