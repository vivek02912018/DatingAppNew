﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dto
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8,MinimumLength =4,ErrorMessage ="You must specify a password between 4 and 8 characters")]
        public string Password { get; set; }

    }
}
