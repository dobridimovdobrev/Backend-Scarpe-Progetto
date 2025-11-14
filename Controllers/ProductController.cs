using Microsoft.AspNetCore.Mvc;
using Scarpe___Co_Progetto.LocalDatabase;

namespace Scarpe___Co_Progetto.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductsList.GetAll();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductsList.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
