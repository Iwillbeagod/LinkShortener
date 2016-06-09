using System;
using System.IO;
using System.Web.Mvc;

namespace LinkShortenService.Site.Controllers
{
    public class RouteController : Controller
    {
        public ActionResult GetLayout()
        {
            return View("~/Views/Shared/Layout.cshtml");
        }

        public ActionResult GetView(string section, string view)
        {
            var path = String.Format("~/Views/{0}/{1}.cshtml", section, view);
            return GetFile(path);
        }

        public ActionResult GetFile(string path)
        {
            return new FileInfo(Server.MapPath(path)).Exists ? View(path) : GetNotFound();
        }

        public ActionResult GetNotFound()
        {
            Response.StatusCode = 404;
            return View("~/Views/Error.cshtml");
        }
    }
}