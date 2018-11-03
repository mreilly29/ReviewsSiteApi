using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentForReviewId(int reviewId);
        void Create(Comment comment);
    }
}
