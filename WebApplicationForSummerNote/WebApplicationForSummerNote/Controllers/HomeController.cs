using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForSummerNote.Models;

namespace WebApplicationForSummerNote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Index(HttpPostedFileBase aUploadedFile)
        {
            fileupload obj = new fileupload();
            var vReturnImagePath = string.Empty;
            if (aUploadedFile.ContentLength > 0)
            {
                var vFileName = Path.GetFileNameWithoutExtension(aUploadedFile.FileName);
                var vExtension = Path.GetExtension(aUploadedFile.FileName);

                string sImageName = vFileName + DateTime.Now.ToString("YYYYMMDDHHMMSS");

                var vImageSavePath = Server.MapPath("/Upload/") + sImageName + vExtension;
                //sImageName = sImageName + vExtension;  
                vReturnImagePath = "/Upload/" + sImageName + vExtension;
                ViewBag.Msg = vImageSavePath;
                var path = vImageSavePath;

                // Saving Image in Original Mode  
                aUploadedFile.SaveAs(path);
                var vImageLength = new FileInfo(path).Length;
                //here to add Image Path to You Database ,  
                TempData["message"] = string.Format("Image was Added Successfully");

                obj.ContentType = vExtension;
                obj.size = vImageLength.ToString();
            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}