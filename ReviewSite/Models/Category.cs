using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //connects with Review class
        public virtual List<Review> Reviews { get; set; }
    }
}
