using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MassProduct:Product
    {
        public MassProduct()
        {

        }
        public MassProduct(string designer)
        {
            Designer = designer;
        }
        public string Designer { get; set; }
    }
}
