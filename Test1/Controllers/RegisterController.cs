using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // POST: Verify
        [HttpPost]
        public ActionResult Verify(RegisterModel model)
        {
            var lstDocument = model.category == 0 ? model.documentsPriv : model.documentsOther;
            var strFilePath = "C:/Users/Gideon/Desktop/Documents";
            string strDocsMsg = "";
            foreach (var file in lstDocument)
            {
                strDocsMsg = "";
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);

                    file.SaveAs(Path.Combine(@strFilePath, fileName));
                    strDocsMsg = lstDocument.Count() + " FILES UPLOADED SUCCESS";
                }
            }

            ViewBag.test = model.companyName;
            ViewBag.category = model.category;
            ViewBag.pathName = strDocsMsg;
            return View("Index");
        }
    }
}