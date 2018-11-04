using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //connects many to many with review class
        [JsonIgnore]
        public virtual List<ReviewTag> ReviewTags { get; set; }        
    }
}
