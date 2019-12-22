﻿using System;
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

        public static UsersModel GetUser(string _username, string _password)
        {
            string sql = String.Format("SELECT Username, Password, FirstName, LastName, EmailAddress, PhoneNumber, Role from dbo.tbl_Users WHERE Username = '{0}' AND Password = '{1}' ", _username, _password);
            List<UsersModel> user = SqlDataAccess.LoadData<UsersModel>(sql);

            System.Diagnostics.Debug.WriteLine(sql);

            if (user.Count > 0)
                return user[0];
            else
                return null;
        }
    }
}
