using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataLibrary.Models;

namespace DacSan.Models
{
    public class UsersModel
    {
        public int Id { get; set; }
        
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage ="Bạn cần phải nhập tài khoản")]
        public string Username { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string Password { get; set; }

        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Bạn cần phải nhập tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        [Required(ErrorMessage = "Bạn cần phải nhập họ")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Bạn cần phải nhập email")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Email không hợp lệ")]
        public string EmailAddress { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Bạn cần phải nhập số điện thoại")]
        public string PhoneNumber { get; set; }
        public int Role { get; set; }

        public UsersModel(DataLibrary.Models.UsersModel _user)
        {
            this.Id = _user.Id;
            this.Username = _user.Username;
            this.Password = _user.Password;
            this.FirstName = _user.FirstName;
            this.LastName = _user.LastName;
            this.EmailAddress = _user.EmailAddress;
            this.PhoneNumber = _user.PhoneNumber;
        }

        public UsersModel() { }
    }
}