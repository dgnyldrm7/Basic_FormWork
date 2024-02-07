using System.Diagnostics;
using FormWorks.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormWorks.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Profil product)
        {

            if (ModelState.IsValid)   //ModelState.IsValid  hi�bir hata yoku temsil eder
            {
                Repository.AddProfil(product);
                return View(product);
            }
            else
            {
                return View(product);
            }
        }

        
        //Burada arama i�lemleri yap ve s�ralama
        public IActionResult Privacy(string search)
        {

            var Profil = Repository._ShowProfilList;

            if (!String.IsNullOrEmpty(search))
            {
                Profil = Profil.Where(p => p.Name.Contains(search)).ToList();
            }


            return View(Profil);
        }

        

       
    }
}
