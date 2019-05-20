using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolcu.Models.PostVM
{
    public class DetailsVM
    {
        public IEnumerable <Post> Post { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
