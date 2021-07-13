using ExcelOperation.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcelOperation.Controllers
{
    public class ExcelImportController : Controller
    {
        public ActionResult Import()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(FormCollection formCollection)
        {
            var LinkList = new List<ExcelImport>();
            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["UploadedFile"];
                if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
                {
                    string fileName = file.FileName;
                    string fileContentType = file.ContentType;
                    byte[] fileBytes = new byte[file.ContentLength];
                    var data = file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                    using (var package = new ExcelPackage(file.InputStream))
                    {
                        
                        var currentSheet = package.Workbook.Worksheets;
                        var workSheet = currentSheet.First();
                        var noOfCol = workSheet.Dimension.End.Column;
                        var noOfRow = workSheet.Dimension.End.Row;
                        for (int rowIterator = 7; rowIterator <= noOfRow; rowIterator++)
                        {
                            var Imp = new ExcelImport();
                            
                            Imp.Name = workSheet.Cells[rowIterator, 2].Value.ToString();
                            Imp.Gender = workSheet.Cells[rowIterator, 3].Value.ToString();
                            Imp.Age= Convert.ToInt32(workSheet.Cells[rowIterator, 4].Value);
                            LinkList.Add(Imp);
                        }
                    }
                }
            }
            using (ExcelEntities ME = new ExcelEntities())
            {
                foreach (var item in LinkList)
                {
                    ME.ExcelImports.Add(item);
                }
                ME.SaveChanges();
            }
            return View("Import");
        }
    }
}