using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReviewSite
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(Context context) : base(context)
        {
            // This ensures our base constructor gets run.

        }
                
    }
}