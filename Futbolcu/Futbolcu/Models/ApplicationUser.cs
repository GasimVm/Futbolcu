using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Futbolcu.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,StringLength(200)]
        public string Firstname { get; set; }
        [Required, StringLength(200)]

        public string Lastname { get; set; }
        [StringLength(300)]

        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
