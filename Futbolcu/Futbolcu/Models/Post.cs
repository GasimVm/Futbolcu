using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace Futbolcu.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        
        [Required, StringLength(400)]
        public string Description { get; set; }

        public DateTime Date { get; set; }
        [StringLength(400)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        
        public int Count { get; set; }

        public string Video { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
