using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapp1.Models;

namespace webapp1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random(string isbn)
        {
            ECOMM_S3Entities r = new ECOMM_S3Entities();

            List<Movies> minfo = new List<Movies>();
            var data = r.sp_getproducts().ToList();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ISBN_13.ToString().ToLower() == isbn)
                {
                    Movies uobj = new Movies();
                    uobj.ISBN_13 = data[i].ISBN_13.ToString();
                    uobj.Title = data[i].Title.ToString();
                    minfo.Add(uobj);
                }
            }
            //ViewBag.userdetails = minfo;
            return View(minfo.AsEnumerable());
            //var movie = new Movies { category = "Telugu", Name = "AGNI!!" };
            //return View(movie);
        }

        public ActionResult MovieList()
        {
            return Content("test movie -- lan-> telugu ....");
        }
    }
}