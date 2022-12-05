using Microsoft.AspNetCore.Mvc;
using Example.Models;
using Example.Data;
using Microsoft.EntityFrameworkCore;


namespace Example.Controllers
{
    public class WorkmanController : Controller
    {
        private readonly Context _context;

        public WorkmanController(Context context) //constructor metot
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listele=_context.Workmans.ToArrayAsync();
            return View(listele);
        }
    }
}
