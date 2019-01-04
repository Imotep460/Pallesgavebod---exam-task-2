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
        [Key]
        [DisplayName("Gift id")]
        public int GiftNumber { get; set; }

        [DisplayName("Gift name")]
        public string Title { get; set; }
        [DisplayName("Gift Description")]
        public string Description { get; set; }
        [DisplayName("Date item was added in system")]
        public DateTime CreationDate { get; set; }
        public bool BoyGift { get; set; }
        public bool GirlGift { get; set; }
    }
}
