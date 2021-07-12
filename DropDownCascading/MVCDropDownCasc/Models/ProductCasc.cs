using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDropDownCasc.Models
{
    public class ProductCasc
    {
        public int ProductId { get; set; }
        public int CatId { get; set; }
        public int SubCatId { get; set; }
    }
}