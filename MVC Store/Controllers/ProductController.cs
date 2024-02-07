using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Store.Data;
using MVC_Store.Models;
using System.Diagnostics;

namespace MVC_Store.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Phone[] phones = _context.Phones.ToArray();
            _context.Categories.ToList();

            return View(phones);
        }

        [HttpGet]
        public IActionResult AddPhone()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPhone(Phone phoneFromForm)
        {
            _context.Phones.Add(phoneFromForm);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPhone(int phoneId)
        {
            Phone phone = _context.Phones.Find(phoneId);
            //_context.Categories.ToList();

            return View(phone);
        }
        [HttpPost]
        public IActionResult EditPhone(Phone phoneFromForm)
        {
            _context.Phones.Update(phoneFromForm);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePhone(int phoneId)
        {
            Phone phone = _context.Phones.Find(phoneId);
            _context.Phones.Remove(phone);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}