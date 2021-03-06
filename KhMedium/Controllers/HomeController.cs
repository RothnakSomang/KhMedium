﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using KhMedium.Data;
using KhMedium.Entities;
using KhMedium.Models;

namespace KhMedium.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork _context = new UnitOfWork(new KhMediumEntities());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}