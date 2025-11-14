using Microsoft.AspNetCore.Mvc;
using Scarpe___Co_Progetto.LocalDatabase;
using Scarpe___Co_Progetto.Models;
using System.Diagnostics;

namespace Scarpe___Co_Progetto.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            var products = ProductsList.GetAll();
            return View(products);
        }

      
       
    }
}
