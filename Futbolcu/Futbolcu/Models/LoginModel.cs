using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolcu.Models
{
    public class LoginModel
    {
        [Required, StringLength(200)]
        public string Email { get; set; }
        [Required, StringLength(200)]
        public string Password { get; set; }
        public bool RemenberMe { get; set; }
    }
}
