using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Provision { get; set; }
        public decimal StartingPrice { get; set; }
        public string Supplier { get; set; }

        private void SetStartPrice(decimal startPrice)
        {
            StartingPrice = startPrice;
        }
    }
}
