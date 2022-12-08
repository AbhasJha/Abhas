using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        public static int pageSize = 20;
        private readonly IFizzBuzzService service;

        public FizzBuzzController(IFizzBuzzService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View(new FizzbuzzViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Display(FizzbuzzViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            List<String> data = service.GetFizzBuzzNumbers(model.Input);

            if(HttpContext != null)
            HttpContext.Session.SetString("TotalData", JsonConvert.SerializeObject(data));

            return View("Display",PaginatedList<string>.Create(data, 1, pageSize));
            
        }
        public IActionResult Display(int pageNumber = 1)
        {
            string json = HttpContext.Session.GetString("TotalData");
            var data = JsonConvert.DeserializeObject<List<string>>(json);

            return View("Display" ,PaginatedList<string>.Create(data, pageNumber, pageSize));
        }
    }
}
