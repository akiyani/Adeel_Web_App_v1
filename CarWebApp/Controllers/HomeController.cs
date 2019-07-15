using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarBusinessLayer;
using CarModelLayer;
using CarDataLayer;

namespace CarWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Introduction";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Have a Question / Suggestion / Solution?";

            return View();
        }

        //Defining new Action
        public ActionResult CarProjectView()
        {
            ViewBag.Message = "The Car Web App - ICE and Electric Vehicles.";

            //Get CarData from Business Layer
            var CarInfoList = CarBusinessClass.GetIndivCarData();

            return View(CarInfoList);
        }

        

    }


}