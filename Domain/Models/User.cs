using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Bid> Bids { get; set; }

        public void JoinRound()
        {

        }
        public void PlaceBid()
        {

        }
    }
    
}
