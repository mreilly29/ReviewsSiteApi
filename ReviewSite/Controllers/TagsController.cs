
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class TagsController : Controller
    {
        private ITagRepository tagRepo;

        public TagsController(ITagRepository tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        public ViewResult Details(int id)
        {
            var model = tagRepo.GetById(id);
            return View(model);
        }
    }
}
