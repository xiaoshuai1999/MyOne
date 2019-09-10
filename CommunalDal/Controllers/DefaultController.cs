using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunalBLL.Entity;
using CommunalBLL.Helper;
namespace CommunalDal.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {


            HttpPostHelper.GetWenZhangDetails();
            //HttpPostHelper.Readjson("/Resources/Json/shuai.txt");

            return View();
        }

    }
}