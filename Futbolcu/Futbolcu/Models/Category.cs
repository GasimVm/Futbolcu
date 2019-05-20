using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolcu.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
       
         
    }
}
