using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolcu.Models.PostVM
{
    public class PostVM
    {

        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
