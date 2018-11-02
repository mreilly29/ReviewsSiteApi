using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }

        //connects to Category class
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
