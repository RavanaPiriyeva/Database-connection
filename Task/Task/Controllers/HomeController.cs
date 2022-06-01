using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Task.DAL;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.OrderBy(x => x.Order).ToList();
            List<Service> services = _context.Services.ToList();

            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                
                Services = services
            };

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
