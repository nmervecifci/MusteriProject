using Microsoft.AspNetCore.Mvc;

namespace MusteriProject.Controllers
{
    // Controllers/MusteriController.cs

    using Microsoft.AspNetCore.Mvc;
    using MusteriProject.Dataa;
    using MusteriProject.Models;


    public class MusteriController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusteriController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Musteri/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musteri/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                // Veritabanına müşteriyi kaydet
                _context.Musteriler.Add(musteri);
                _context.SaveChanges();

                // Başarılı kayıt sonrasında yönlendirme yapabilirsiniz
                return RedirectToAction("Index", "Home");
            }

            // Geçersiz model durumunda aynı sayfaya geri dön
            return View(musteri);
        }
        // GET: Musteri
        public IActionResult Index()
        {
            var musteriler = _context.Musteriler.ToList();
            return View(musteriler);
        }

        // Diğer metodlar...
    }
}

