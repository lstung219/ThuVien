using System;
using System.Data;

public class BusinessLogic
{
    private DataAccess dataAccess;

    public BusinessLogic()  
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

    public void UpdateDGInfo(string maDG, string hoTen, string sdt, string diaChi)
    {
        dataAccess.UpdateDGInfo(maDG, hoTen, sdt, diaChi);
    }

    public void InsertDG(string maDG, string hoTen, string sdt, string diaChi)
    {
        dataAccess.InsertDG(maDG, hoTen, sdt, diaChi);
    }

    public void DeleteDG(string maDG)
    {
        dataAccess.DeleteDG(maDG);
    }
}
