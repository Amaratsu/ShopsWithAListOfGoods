using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Ajax.Utilities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ShopsController : ApiController
    {
        private UnitOfWork unitOfWork;

        public ShopsController()
        {
            unitOfWork = new UnitOfWork();
        }

        // GET: api/Shops/5
        [ResponseType(typeof(JSON))]
        public IHttpActionResult GetShop(int id)
        {
            List<Product> products = unitOfWork.Shops.Get(id).Products.ToList();

            return Ok(products);
        }
    }
}