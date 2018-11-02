﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewRepository reviewRepo;

        public ReviewController(IReviewRepository reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }        
        public ViewResult AllReviews()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }
    }
}
