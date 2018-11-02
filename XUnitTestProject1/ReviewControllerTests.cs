using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewSite;
using ReviewSite.Controllers;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class ReviewsControllerTests
    {
        IReviewRepository reviewRepo;
        ReviewController underTest;

        public ReviewsControllerTests()
        {
            reviewRepo = Substitute.For<IReviewRepository>();
            underTest = new ReviewController(reviewRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_All_Reviews()
        {

            var result = underTest.Index();
            reviewRepo.Received().GetAll();
        }

        [Fact] //controller passes Model into View
        public void Index_Sets_AllDogs_As_Model()
        {
            var expectedModel = new List<Review>();
            reviewRepo.GetAll().Returns(expectedModel);

            var result = underTest.Index();

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Sets_Review_To_Model()
        {
            var expectedModel = new Review();
            reviewRepo.GetById(1).Returns(expectedModel);

            var result = underTest.Details(1);

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }
    }
}
