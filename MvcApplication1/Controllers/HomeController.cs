using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            
            BLL bll = new BLL();
            ViewData["Counter"] = bll.GetCount();
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            
                BLL bll = new BLL();
                bll.Increment();
                ViewData["Counter"] = bll.GetCount();
           
            return View();
        }

    }
}
