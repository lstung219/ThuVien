using System;
using System.Data;
using System.Data.SqlClient;

public class DataAccess
{
    private SqlConnection conn;

    public DataAccess()
    {
        string strcon = @"Data Source=DESKTOP-IKUEPFH\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True";
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

    public void UpdateDGInfo(string maDG, string hoTen, string sdt, string diaChi)
    {
        string strSQL = "UPDATE DOCGIA SET HoTen = @HoTen, Sdt = @Sdt, Diachi = @Diachi WHERE MaDG = @MaDG";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        cmd.Parameters.AddWithValue("@HoTen", hoTen);
        cmd.Parameters.AddWithValue("@Sdt", sdt);
        cmd.Parameters.AddWithValue("@Diachi", diaChi);
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

    public void InsertDG(string maDG, string hoTen, string sdt, string diaChi)
    {
        string strSQL = "INSERT INTO DOCGIA (MaDG, HoTen, Sdt, Diachi) VALUES (@MaDG, @HoTen, @Sdt, @Diachi)";
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        cmd.Parameters.AddWithValue("@MaDG", maDG);
        cmd.Parameters.AddWithValue("@HoTen", hoTen);
        cmd.Parameters.AddWithValue("@Sdt", sdt);
        cmd.Parameters.AddWithValue("@Diachi", diaChi);
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

}
