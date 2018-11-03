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

        //connects one Category to Review
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //connects many to many with Tag class
        public virtual List<ReviewTag> ReviewTags { get; set; }

        //connects many comments to one Review
        public virtual List<Comment> Comments { get; set; }
    }
}
