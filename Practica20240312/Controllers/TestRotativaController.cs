using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

namespace Practica20240312.Controllers
{
    public class TestRotativaController : Controller
    {
        public IActionResult Index()
        {
            return new ViewAsPdf("Index")
            {
                // ...
            };
            //return View();
        }
    }
}
