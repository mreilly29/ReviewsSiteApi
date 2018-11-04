using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewSite.Controllers;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class MVCTagsControllerTests
    {
        ITagRepository tagRepo;
        TagsController underTest;

        public MVCTagsControllerTests()
        {
            tagRepo = Substitute.For<ITagRepository>();
            underTest = new TagsController(tagRepo);
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
            var expectedModel = new Tag();
            tagRepo.GetById(1).Returns(expectedModel);

            var result = underTest.Details(1);

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }
    }
}
