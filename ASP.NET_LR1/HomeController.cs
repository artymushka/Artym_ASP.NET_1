using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var companyInfo = new
            {
                Name = "Vlad's Company",
                Location = "Mykolaiv",
                YearFounded = 2003
            };

            var randomNumber = new Random().Next(101);

            ViewBag.CompanyInfo = companyInfo;
            ViewBag.RandomNumber = randomNumber;

            return View();
        }
    }
}




