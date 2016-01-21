using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class Round
    {
        public Product Product { get; set; }
        public List<Bid> Bids { get; set; }
        public DateTime EndDate { get; set; }

    }
}
