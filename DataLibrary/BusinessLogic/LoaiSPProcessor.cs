using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public static class LoaiSPProcessor
    {
        public static List<LoaiSPModel> LoadLoaiSP()
        {
            string sql = @"SELECT * FROM dbo.tbl_LoaiSP";
            return SqlDataAccess.LoadData<LoaiSPModel>(sql);
        }
    }
}
