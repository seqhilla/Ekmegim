using BusinessLayer.Repositories;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Ekmegim.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository);
        public IActionResult Index()
        {
            var degerler = cm.TumKategorileriGetir();

            return View(degerler);
        }
    }
}
