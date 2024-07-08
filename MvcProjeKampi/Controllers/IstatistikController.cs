using BusinessLayer.Abstarct;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
         ICategoryService _categoryService;
        // GET: Istatistik
       
        public IstatistikController()
        {
            _categoryService = new CategoryManager(new EfCategoryDal(), new EfHeadingDal(), new EfWriterDal());
        }
        public ActionResult Index()
        {
            var sum = _categoryService.GetCategoryCount();
            var yazılım = _categoryService.CategoryCountYl("Yazılım");
            var writer = _categoryService.CategoryWriterACount();
            var fark = _categoryService.CategoryStatusFark();
            var categoryWithMostHeadings = _categoryService.GetCategoryWithMostHeadings();

            ViewBag.CategoryCount = sum;
            ViewBag.SoftwareHeadingCount = yazılım;
            ViewBag.WriterACount = writer;
            ViewBag.CategoryStatusFark = fark;
            ViewBag.CategoryWithMostHeadings = categoryWithMostHeadings;



            return View();


        }
        

    }
}