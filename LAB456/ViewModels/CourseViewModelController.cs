using LAB456.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB456.ViewModels
{
    public class CourseViewModelController : Controller
    {
        // GET: CourseViewModel
        public ActionResult Index()
        {
            return View();
        }
    }
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]

        public string Date { get; set; }
        [Required]

        public string Time { get; set; }
        [Required]

        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime getDateTime()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }

    }
}