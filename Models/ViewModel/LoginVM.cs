using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStore.Models.ViewModel
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Ten dang nhap")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mat Khau")]
        public string Password { get; set; }
    }
}