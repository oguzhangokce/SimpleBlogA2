using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin

    {
        public string Test { get; set; }
        

        [Required]
        [MinLength(3)]
        [MaxLength(16)]
        public string UserName { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(16)]
        public string Password { get; set; }
    }

    public class AuthRegister
    {
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public int StudentNumber { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string StudentSurname { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string StudentEmail { get; set; }
    }
}