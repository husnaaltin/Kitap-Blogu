﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class LoginViewModel
    {

        //[Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Username is required.")]
        [StringLength(30, ErrorMessage="Username can be max 30 characters.")]
        public string Username { get; set; }

        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(3, ErrorMessage="Password  can be min 3 characters.")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters.")]
        public string Password { get; set; }
    }
}
