using NSubstitute;
using ReviewSite.Controllers.Api;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class TagsControllerTests
    {
        [Fact]
        public void GetAll_Returns_All_Tags_For_Given_Review()
        {
            var reviewId = 42;
            var expectedModel = new List<Tag>();
            var tagRepo = Substitute.For<ITagRepository>();
            tagRepo.GetTagsForReviewId(reviewId).Returns(expectedModel);
            var underTest = new TagsController(tagRepo);

            var model = underTest.Get(reviewId);

            Assert.Same(expectedModel, model);
        }

        [Fact]
        public void Post_And_Saves()
        {
            var tag = new Tag();
            var tagRepo = Substitute.For<ITagRepository>();
            var underTest = new TagsController(tagRepo);

            underTest.Post(tag, 42);

            tagRepo.Received().Create(tag);
        }
    }
}
