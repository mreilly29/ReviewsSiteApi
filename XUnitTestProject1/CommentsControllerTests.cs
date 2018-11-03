using NSubstitute;
using ReviewSite.Controllers.Api;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class CommentsControllerTests
    {
        [Fact]
        public void GetAll_Returns_All_Comments_For_Given_Review()
        {
            var reviewId = 42;
            var expectedModel = new List<Comment>();
            var commentRepo = Substitute.For<ICommentRepository>();
            commentRepo.GetCommentForReviewId(reviewId).Returns(expectedModel);
            var underTest = new CommentsController(commentRepo);

            var model = underTest.Get(reviewId);

            Assert.Same(expectedModel, model);
        }
        [Fact]
        public void Post_And_Saves()
        {
            var comment = new Comment();
            var commentRepo = Substitute.For<ICommentRepository>();
            var underTest = new CommentsController(commentRepo);

            underTest.Post(comment);

            commentRepo.Received().Create(comment);
        }
    }
}
