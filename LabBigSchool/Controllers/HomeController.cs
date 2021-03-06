using LabBigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LabBigSchool.ViewModels;

namespace LabBigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController() 
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upCommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now && c.IsCanceled == false);
            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upCommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }
    }
}