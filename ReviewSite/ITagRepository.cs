using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTagsForReviewId(int reviewId);
        void Create(Tag newTag);
    }
}
