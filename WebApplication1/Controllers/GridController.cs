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
        


        public async Task<JsonResult> GetCustomers()
        {
            return Json(((await new CustomerRepository().getAllCustomers()).Result), JsonRequestBehavior.AllowGet);
        }



        public async Task<JsonResult> GetProducts()
        {
            return Json(((await new ProductRepository().getAllProducts()).Result), JsonRequestBehavior.AllowGet);
        }



        public async Task<JsonResult> GetReceipts()
        {
            return Json(((await new ReceiptRepository().getAllReceipts()).Result), JsonRequestBehavior.AllowGet);
        }




    }
}


