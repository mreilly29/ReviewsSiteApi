using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();
        Review GetById(int id);
    }
}
