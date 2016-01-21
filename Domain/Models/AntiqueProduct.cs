using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AntiqueProduct : Product
    {
        public AntiqueProduct()
        {

        }
        public AntiqueProduct(string epoch)
        {
            Epoch = epoch;
        }
        public string Epoch { get; set; }
    }
}
