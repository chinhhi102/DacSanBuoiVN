using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public static class UsersProcessor
    {
        public static int CreateUser(string _Username, string _Password, string _FirstName,
            string _LastName, string _EmailAddress, string _PhoneNumber, int _Role)
        {
            UsersModel data = new UsersModel
            {
                Username = _Username,
                Password = _Password,
                FirstName = _FirstName,
                LastName = _LastName,
                EmailAddress = _EmailAddress,
                PhoneNumber = _PhoneNumber,
                Role = _Role
            };
            string sql = @"insert into dbo.tbl_Users (Username, Password, FirstName, LastName, EmailAddress, PhoneNumber, Role)
                            values(@Username, @Password, @FirstName, @LastName, @EmailAddress, @PhoneNumber, @Role)";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<UsersModel> LoadUsers()
        {
            string sql = @"select Username, Password, FirstName, LastName, EmailAddress, PhoneNumber, Role
                           from dbo.tbl_Users";
            return SqlDataAccess.LoadData<UsersModel>(sql);
        }
    }
}
