using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDownCascading.Models
{
    public class ProductsCasc
    {
        public int ProductId { get; set; }
        public int CatId { get; set; }
        public int SubCatId { get; set; }
    }
}