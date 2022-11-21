using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        [HttpGet]
        public IActionResult Display()
        {
            return View("Index",new FizzbuzzViewModel());
        }

        [HttpPost]
        public IActionResult Display(FizzbuzzViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",model);
            }
            List<DisplayViewModel> data= service.GetFizzBuzzNumbers(model.Input);
            int pageSize = 20;
            ViewBag.TotalData = data;
            return View(PaginatedList<DisplayViewModel>.Create(data,1, pageSize));
        }
        [HttpPost]
        public IActionResult PageIndex(List<DisplayViewModel> data, int PageIndex)
        {
            int pageSize = 20;
            return View(PaginatedList<DisplayViewModel>.Create(data, PageIndex, pageSize));
        }
    }
}
