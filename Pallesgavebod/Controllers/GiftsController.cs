using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pallesgavebod.Data;
using Pallesgavebod.Models;

namespace Pallesgavebod.Controllers
{
    public class GiftsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GiftsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gifts
        public ActionResult Gifts()
        {
            var allGifts = _context.Gifts;

            return View(allGifts);
        }

        //// GET: Gifts/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Gifts/Create
        public ActionResult Create(Gift gift)
        {
            var newitem = new Gift();

            newitem.CreationDate = DateTime.Now;
            newitem.Description = gift.Description;
            newitem.Title = gift.Title;
            newitem.BoyGift = gift.BoyGift;
            newitem.GirlGift = gift.GirlGift;

            _context.Gifts.Add(newitem);
            _context.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult Boys(Gift gift)
        {
            var boyitems = from a in _context.Gifts
                           where a.BoyGift == true
                           select new Gift { GiftNumber = a.GiftNumber, Title = a.Title, CreationDate = a.CreationDate, Description = a.Description };

            return View(boyitems);
        }

        // GET: Gifts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gifts/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Gifts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gifts/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}