using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ModernProduct:Product
    {
        public ModernProduct()
        {

        }
        public ModernProduct(string designer)
        {
            Designer = designer;
        }
        public string Designer { get; set; }
    }
}
