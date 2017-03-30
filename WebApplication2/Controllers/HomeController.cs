using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork;

        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }

        public ActionResult Index()
        {
            IEnumerable<Shop> shops = unitOfWork.Shops.GetAll();
            return View(shops);
        }
    }
}
