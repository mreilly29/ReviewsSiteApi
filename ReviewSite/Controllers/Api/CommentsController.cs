using Microsoft.AspNetCore.Mvc;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private ICommentRepository commentRepo;

        public CommentsController(ICommentRepository commentRepo)
        {
            this.commentRepo = commentRepo;
        }

        // GET list of comments for each Todo
        [HttpGet("{reviewId}")]
        public IEnumerable<Comment> Get(int reviewId)
        {
            return commentRepo.GetCommentForReviewId(reviewId);
        }

        [HttpPost]
        public bool Post([FromBody]Comment newComment)
        {
            newComment.CreatedAt = DateTime.UtcNow;
            commentRepo.Create(newComment);
            return true;
        }
    }
}
