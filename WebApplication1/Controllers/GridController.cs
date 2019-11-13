using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using WebApplication1.Custom.Models;
using System.Linq;
using System;
using System.IO;
using System.Web;
using WebApplication1.Custom.Repositories;
using Dapper;
using System.Threading.Tasks;


namespace Kendo.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        List<Customer> list;
        private List<Customer> GenerateInstances()
        {
            list = new List<Customer>() {
             new Customer(1,"John"),
            new Customer(2, "John"),
             new Customer(5, "Josh"),
                new Customer(1,"John"),
                new Customer(3, "Test"),
                new Customer(3, "Test"),
                new Customer(4, "Josh"),
                new Customer(4, "Josh"),
               new Customer(2, "John"),
               new Customer(5, "Josh"),
                new Customer(11,"John"),
                new Customer(32, "Test"),
                new Customer(34, "Test"),
                new Customer(14, "Josh"),
                new Customer(15, "Josh"),
               new Customer(12, "John"),
               new Customer(25, "Josh")
            };
            int i = 0;
            list.ForEach(e =>
            {
                if (i++ % 2 == 0)
                {
                    e.age = 7 + i;
                    e.status = "married";
                    return;
                }
                e.age = 7 + i;
                e.status = "single";
            });
            return list;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Editing_Destroy([DataSourceRequest] DataSourceRequest request, int id)
        {

            if (GenerateInstances().Any())
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].id == id)
                        list.RemoveAt(i);
                }
            }
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }


        private List<string> GenerateNames()
        {
            List<string> list = GenerateInstances().Select(e => e.name).Distinct().ToList<string>();
            return list;
        }

        public ActionResult GenerateUnique(string field)
        {
            dynamic list = null;

            if (string.Equals(field, "age"))
                list = GenerateInstances().Select(e => new { e.age }).Distinct();
            else if (string.Equals(field, "status"))
                list = GenerateInstances().Select(e => new { e.status }).Distinct();
            else if (string.Equals(field, "name"))
                list = GenerateInstances().Select(e => new { e.name }).Distinct();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        private List<int> GenerateAges()
        {
            List<int> list = GenerateInstances().Select(e => e.age).Distinct().ToList<int>();
            return list;
        }
        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<Customer> list = GenerateInstances();
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Pdf_Export()
        {
            return View();
        }

        public ActionResult Pdf_Export_Read([DataSourceRequest]DataSourceRequest request)
        {
            return Json(GenerateInstances().ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        public ActionResult Basic_Usage_Submit(IEnumerable<HttpPostedFileBase> files)
        {
           // HttpPostedFileBase gg = null;
            if (files != null)
            {
                TempData["UploadedFiles"] = Basic_Usage_Get_File_Info(files);
                foreach (var item in files)
                {
                    var gggggg = item;
                    string targetFolder = Server.MapPath("~/Content/");
                    string targetPath = Path.Combine(targetFolder, gggggg.FileName);
                    gggggg.SaveAs(targetPath);
                }
            }



            return RedirectToAction("About", "Home");
        }

        public ActionResult Result()
        {
            return View();
        }

        private IEnumerable<string> Basic_Usage_Get_File_Info(IEnumerable<HttpPostedFileBase> files)
        {
            return
                from a in files
                where a != null
                select string.Format("{0} ({1} bytes)", Path.GetFileName(a.FileName), a.ContentLength);
        }



        public JsonResult NamesAutocomplete(string text)
        {
            IEnumerable<dynamic> names = null;
            if (text != null && !string.Equals(text, ""))
            {
                names = GenerateInstances().Where(item => item.
                name.ToLower().Contains(text.ToLower()));
                return Json(names, JsonRequestBehavior.AllowGet);
            }
            return Json(GenerateInstances(), JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        public async Task<JsonResult> getPeople([DataSourceRequest]DataSourceRequest request)
        {
            var a = Json( (await new PersonRepository().getPeople()).Result.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            return a;
            //return Json(new PersonRepository().GetRoleNameFromId(id), JsonRequestBehavior.AllowGet);
        }
      
        public async Task<JsonResult> InsertPerson() {

            return Json((await new PersonRepository().InsertPerson(null)).HasAffected, JsonRequestBehavior.AllowGet);

        }


        public async Task<JsonResult> DeletePerson(int id)
        {
            return Json((await new PersonRepository().DeletePerson(id)).HasAffected, JsonRequestBehavior.AllowGet);
        }



        public async Task<JsonResult> GetCustomers()
        {
            return Json(((await new CustomerRepository().getAllCustomers()).Result), JsonRequestBehavior.AllowGet);
        }


    }
}


