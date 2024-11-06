using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MyStore.Models.ViewModel
{
    public class RegisterVM
    {
        [Required]
        [Display(Name ="Ten dang nhap")]
       public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mat Khau")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Xac nhan mat Khau")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Mat khau va xac nhan mat khau khong khop.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Ho Ten")]
        public string CustomerName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "So dien thoai")]
        public string CustomerPhone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }
        [Required]
        [Display(Name = "Dia chi")]
        public string CustomerAddress { get; set; }
    }
}