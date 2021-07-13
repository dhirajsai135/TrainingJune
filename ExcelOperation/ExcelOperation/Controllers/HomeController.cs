using ExcelOperation.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcelOperation.Controllers
{
    public class HomeController : Controller
    {
        ExcelEntities db = new ExcelEntities();

        public ActionResult Index()
        {
            List<ExcelExportViewModel> eelist = db.ExcelExports.Select(i => new ExcelExportViewModel
            {
                Id = i.Id,
                Name=i.Name,
                Gender=i.Gender,
                Age=i.Age
            }).ToList();
            return View(eelist);
        }


        public void ExportToExcel()
        {
            List<ExcelExportViewModel> eelist = db.ExcelExports.Select(i => new ExcelExportViewModel
            {
                Id = i.Id,
                Name = i.Name,
                Gender = i.Gender,
                Age = i.Age
            }).ToList();
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");

            ws.Cells["A1"].Value = "Communication";
            ws.Cells["B1"].Value = "Com1";

            ws.Cells["A2"].Value = "Date";
            ws.Cells["B1"].Value = string.Format("{0:dd MMMM yyyy} ate {0:H: mm tt}",DateTimeOffset.Now);

            ws.Cells["A6"].Value = "Id";
            ws.Cells["B6"].Value = "Name";
            ws.Cells["C6"].Value = "Gender";
            ws.Cells["D6"].Value = "Age";

            int rowStart = 7;
            foreach(var item in eelist)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.Id;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.Name;
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.Gender;
                ws.Cells[string.Format("D{0}", rowStart)].Value = item.Age;
                rowStart++;
            }
            ws.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("Content-dispostion", "attachment:filename=" + "Export.xlsx");
            Response.BinaryWrite(pck.GetAsByteArray());
            Response.End();


        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}