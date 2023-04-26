using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    [Route("seller")]
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            seller.BirthDate = seller.BirthDate.ToUniversalTime();
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}