using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(Context db) : base(db)
        {

        }

        public IEnumerable<Tag> GetTagsForReviewId(int reviewId)
        {
            var allTags = from tags in GetAll()
                          from reviewTag in tags.ReviewTags
                          where reviewTag.ReviewId == reviewId
                          select reviewTag.Tag;

            return allTags;
        }
    }
}