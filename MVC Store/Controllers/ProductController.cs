using Microsoft.AspNetCore.Mvc;
using MVC_Store.Models;
using System.Diagnostics;

namespace MVC_Store.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {
        }

        public IActionResult Index()
        {
            Phone[] phone = new Phone[3];
            phone[0] = new Phone();
            phone[0].Name = "IPhone 7";
            phone[0].Category = "Smartphone";
            phone[0].Price = 500;
            phone[1] = new Phone();
            phone[1].Name = "IPhone 8";
            phone[1].Category = "Smartphone";
            phone[1].Price = 600;
            phone[2] = new Phone();
            phone[2].Name = "IPhone 9";
            phone[2].Category = "Smartphone";
            phone[2].Price = 700;

            return View(phone);
        }
    }
}