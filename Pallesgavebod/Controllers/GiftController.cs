//using Microsoft.AspNetCore.Mvc;
//using Pallesgavebod.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Pallesgavebod.Controllers
//{
//    [Route("api/Gifts")]
//    [ApiController]
//    public class GiftController : ControllerBase
//    {
//        private readonly GiftsContext _context;

//        public GiftController(GiftsContext context)
//        {
//            _context = context;
//        }


//        //Get api/Gifts
//        [HttpGet]
//        public IEnumerable<Gift> GetGifts()
//        {
//            return _context.Gifts;
//        }

//        //POST api/<controller>
//        [HttpPost]
//        public IActionResult PostGift([FromBody] Gift gift)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            _context.Gifts.Add(gift);
//            _context.SaveChangesAsync();
//            return CreatedAtAction("GetGift", new { gift.GiftNumber }, gift);
//        }
//    }
//}
