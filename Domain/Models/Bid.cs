using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
    public class Bid
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public Round Round { get; set; }
        public User User { get; set; }

    }
}
