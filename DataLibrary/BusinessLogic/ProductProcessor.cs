using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public static class ProductProcessor
    {
        public static int CreateProduct(string _TenSP, string _Mota, int _LoaiSPID, int _DiaChiID)
        {
            ProductModel data = new ProductModel
            {
                TenSP = _TenSP,
                MoTa = _Mota,
                LoaiSPID = _LoaiSPID,
                DiaChiID = _DiaChiID
            };
            string sql = @"INSERT INTO dbo.tbl_SanPham VALUES(@TenSP, @MoTa, @LoaiSPID, @DiaChiID)";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ProductModel> LoadProducts()
        {
            string sql = @"SELECT * FROM dbo.tbl_SanPham";
            return SqlDataAccess.LoadData<ProductModel>(sql);
        }
    }
}
