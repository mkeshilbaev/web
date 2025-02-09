﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Login_Report.Models
{
    public class UserLogin
    {
        [Display(Name ="Email ID")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Email ID is required")]
        public string EmailID { get; set; }



        [Required(AllowEmptyStrings =false, ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}