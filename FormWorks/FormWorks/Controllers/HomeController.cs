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

            if (ModelState.IsValid)   //ModelState.IsValid  hiçbir hata yoku temsil eder
            {
                Repository.AddProfil(product);
                return View(product);
            }
            else
            {
                return View(product);
            }
        }

        
        //Burada arama iþlemleri yap ve sýralama
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
