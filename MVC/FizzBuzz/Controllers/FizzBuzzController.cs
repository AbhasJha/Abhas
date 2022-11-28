using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
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
        public IActionResult Display(FizzbuzzViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            List<DisplayViewModel> data = service.GetFizzBuzzNumbers(model.Input);
            HttpContext.Session.SetString("TotalData", JsonConvert.SerializeObject(data));
            int pageSize = 20;
            return View(PaginatedList<DisplayViewModel>.Create(data, 1, pageSize));
        }
        public IActionResult Display(int pageNumber = 1)
        {
            string json = HttpContext.Session.GetString("TotalData");
            List<DisplayViewModel> data = JsonConvert.DeserializeObject<List<DisplayViewModel>>(json);
            int pageSize = 20;
            return View(PaginatedList<DisplayViewModel>.Create(data, pageNumber, pageSize));
        }
    }
}
