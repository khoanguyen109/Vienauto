using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VienautoMobile.Models.Form
{
    public class AccountFormModel
    {
        [Required(ErrorMessage = "Chưa nhập tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        public string PassWord { get; set; }
        [Display(Name = "Remember me?")]
        public bool? RememberMe { get; set; }
    }
}