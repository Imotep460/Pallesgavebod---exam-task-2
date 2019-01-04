using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pallesgavebod.Models
{
    public class Gift
    {
        [Required]
        [DisplayName("Gift id")]
        public int GiftNumber { get; set; }
        [Required]
        [DisplayName("Gift name")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please add a description for the item in question")]
        [DisplayName("Gift Description")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Date item was added in system")]
        public DateTime CreationDate { get; set; }
        public bool BoyGift { get; set; }
        public bool GirlGift { get; set; }
    }
}
