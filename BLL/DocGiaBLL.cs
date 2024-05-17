using System;
using System.Data;

public class DocGiaBLL
{
    private DataAccess dataAccess;

    public DocGiaBLL()  
    {
        dataAccess = new DataAccess();
    }

    public DataTable GetDSDG()
    {
        return dataAccess.GetDSDG();
    }

    public bool CheckMaDG(string maDG)
    {
        return dataAccess.CheckMaDG(maDG);
    }

    public void UpdateDGInfo(string maDG, string hoTen, string sdt, string diaChi, DateTime ngaySinh, string gioiTinh, string email)
    {
        dataAccess.UpdateDGInfo(maDG, hoTen, sdt, diaChi, ngaySinh, gioiTinh, email);
    }

    public void InsertDG(string maDG, string hoTen, string sdt, string diaChi, DateTime ngaySinh, string gioiTinh, string email)
    {
        dataAccess.InsertDG(maDG, hoTen, sdt, diaChi, ngaySinh, gioiTinh, email);
    }

    public bool DeleteDG(string maDG)
    {
        return dataAccess.DeleteDG(maDG);
    }
    public string TimMaDocGiaTiepTheo()
    {
        return dataAccess.TimMaDocGiaTiepTheo();
    }
    public DataTable XemChiTietDocGia(string maDG)
    {
         return dataAccess.XemChiTietDocGia(maDG);
    }
}
