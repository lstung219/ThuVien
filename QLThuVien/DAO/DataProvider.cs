using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get{ if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string conectinonstr = @"Data Source=DESKTOP-IKUEPFH\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHI;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(conectinonstr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if(parameter != null) 
                {
                    string[] listpar = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpar)
                    {
                        if(item.Contains ('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(conectinonstr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpar = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpar)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //data = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(conectinonstr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpar = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpar)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
