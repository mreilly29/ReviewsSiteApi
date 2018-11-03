using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(Context db) : base(db)
        {

        }
        public IEnumerable<Comment> GetCommentForReviewId(int reviewId)
        {
            return from comment in GetAll()
                   where comment.ReviewId == reviewId
                   orderby comment.CreatedAt
                   select comment; //returns new list of comments that relate to specific Todo Id that is passed in  
        }
    }
}
