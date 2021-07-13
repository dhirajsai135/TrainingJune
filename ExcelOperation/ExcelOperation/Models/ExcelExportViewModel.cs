using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelOperation.Models
{
    public class ExcelExportViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }
    }
}