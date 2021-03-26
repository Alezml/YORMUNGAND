using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Controllers
{
    public class TestController : Controller
    {
        private readonly ITest _allids;
        public TestController(ITest iAllids)
        {
            _allids = iAllids;
        }
        [Route("TEST/ids")]

        //[Route("CESS/{id}")]
        public ViewResult List(string id)
        {

            IEnumerable<TestModel> ids = null;

            ids = _allids.TestModels.OrderBy(i => i.Test3);

            ViewBag.Title = "TEST -=- TEST";
            return View(ids);
        }
        public ActionResult Export()
        {
            List<PhoneBrand> phoneBrands = new List<PhoneBrand>();
            phoneBrands.Add(new PhoneBrand()
            {
                Title = "Apple",
                PhoneModels = new List<PhoneModel>()
            {
                new PhoneModel() { Title = "iPhone 7"},
                new PhoneModel() { Title = "iPhone 7 Plus"}
            }
            });
            phoneBrands.Add(new PhoneBrand()
            {
                Title = "Samsung",
                PhoneModels = new List<PhoneModel>()
            {
                new PhoneModel() { Title = "A3"},
                new PhoneModel() { Title = "A3 2016"},
                new PhoneModel() { Title = "A3 2017"}
            }
            });

            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Brands");

                worksheet.Cell("A1").Value = "Бренд";
                worksheet.Cell("B1").Value = "Модели";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < phoneBrands.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = phoneBrands[i].Title;
                    worksheet.Cell(i + 2, 2).Value = string.Join(", ", phoneBrands[i].PhoneModels.Select(x => x.Title));
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"brands_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }
    }
}
