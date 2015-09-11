using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tag_it.Controllers
{
    public class DefaultController : Controller
    {
        List<string> list = new List<string> { "c++", "java", "php", "coldfusion", "javascript", "asp", "ruby", "python", "c", "scala", "groovy", "haskell", "perl", "erlang", "apl", "cobol", "go", "lua" };

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetLabels(string search)
        {
            return Json(list.Where(x => x.StartsWith(search)));
        }
    }
}