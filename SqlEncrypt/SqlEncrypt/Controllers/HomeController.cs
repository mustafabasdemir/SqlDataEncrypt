using Microsoft.AspNetCore.Mvc;
using SqlEncrypt.Data;
using SqlEncrypt.Models;
using System.Diagnostics;

namespace SqlEncrypt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        public IActionResult Privacy()
        {
            _context.Add(new Employee { IdentificationNumber = "10233654789", FirstName = "test", LastName = "kullanici", CreditCardNumber = 963258741});
            _context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
