using System;
using System.Data;
using System.Data.SqlClient;

public class DataAccess
{
    private SqlConnection conn;

    public DataAccess()
    {
        string strcon = @"Data Source=SONTUNG;Initial Catalog=QLTHUVIEN;Integrated Security=True";
        conn = new SqlConnection(strcon);
    }

    public void OpenConnection()
    {
        try
        {
            conn.Open();
        }
        catch (Exception ex)
        {
            throw new Exception("Không kết nối được CSDL.", ex);
        }
    }

    public void CloseConnection()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }

    public DataTable GetDSDG()
    {
        DataTable dt = new DataTable();
        string strSQL = "SELECT * FROM DOCGIA";

        try
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
        catch (Exception ex)
        {
            throw new Exception("Không thể lấy dữ liệu từ CSDL.", ex);
        }

        return dt;
    }

    public bool CheckMaDG(string maDG)
    {
        string strSQL = "SELECT COUNT(*) FROM DOCGIA WHERE MaDG = @MaDG";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        cmd.Parameters.AddWithValue("@MaDG", maDG);
        try
        {
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        finally
        {
            conn.Close();
        }
    }

    public void UpdateDGInfo(string maDG, string hoTen, string sdt, string diaChi, DateTime ngaySinh, string gioiTinh, string email)
    {
        string strSQL = "UPDATE DOCGIA SET HoTen = @HoTen, Sdt = @Sdt, Diachi = @Diachi, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, GMAIL = @gmail  WHERE MaDG = @MaDG";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        cmd.Parameters.AddWithValue("@HoTen", hoTen);
        cmd.Parameters.AddWithValue("@Sdt", sdt);
        cmd.Parameters.AddWithValue("@Diachi", diaChi);
        cmd.Parameters.AddWithValue("@MaDG", maDG);
        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
        cmd.Parameters.AddWithValue("@gmail", email);
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public void InsertDG(string maDG, string hoTen, string sdt, string diaChi, DateTime ngaySinh, string gioiTinh, string email)
    {   
        string strSQL = "INSERT INTO DOCGIA (MaDG, HoTen, Sdt, Diachi, NgaySinh, GioiTinh, GMAIL) VALUES (@MaDG, @HoTen, @Sdt, @Diachi, @NgaySinh, @GioiTinh,@gmail)";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        cmd.Parameters.AddWithValue("@MaDG", maDG);
        cmd.Parameters.AddWithValue("@HoTen", hoTen);
        cmd.Parameters.AddWithValue("@Sdt", sdt);
        cmd.Parameters.AddWithValue("@Diachi", diaChi);
        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
        cmd.Parameters.AddWithValue("@gmail", email);
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public void DeleteDG(string maDG)
    {
        string strSQL = "DELETE FROM DOCGIA WHERE MaDG = @MaDG";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        cmd.Parameters.AddWithValue("@MaDG", maDG);
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }
    public string TimMaDocGiaTiepTheo()
    {
        string maDocGiaTiepTheo = string.Empty;
            SqlCommand cmd = new SqlCommand("usp_TimMaDGTiepTheo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaDocGia", SqlDbType.NVarChar, 10);
            p.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                maDocGiaTiepTheo = p.Value.ToString();
            }
            finally
            {
                conn.Close();
            }
        

        return maDocGiaTiepTheo;
    }
    public DataTable XemChiTietDocGia(string maDG)
    {
        string strSQL = "SELECT * FROM DOCGIA WHERE MaDG = @MaDG";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        DataTable dt = new DataTable();
        cmd.Parameters.AddWithValue("@MaDG", maDG);
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
        finally
        {
            conn.Close();
        }
        return dt;
    }
}
