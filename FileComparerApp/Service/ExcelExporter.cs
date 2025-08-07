using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Collections.Generic;
using FileComparerApp.DataModel;

namespace FileComparerApp.Service
{
    public class ExcelExporter
    {
        public static void ExportToExcel(List<LineComparisonResult> results)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Differences");

            //Header
            worksheet.Cell(1, 1).Value = "Line Number";
            worksheet.Cell(1, 2).Value = "File1 Content";
            worksheet.Cell(1, 3).Value = "File2 Content";
            worksheet.Cell(1, 4).Value = "Status";

            //Data
            int row = 2;
            foreach (var result in results)
            {
                worksheet.Cell(row, 1).Value = result.LineNumber;
                worksheet.Cell(row, 2).Value = result.File1Line;
                worksheet.Cell(row, 3).Value = result.File2Line;
                worksheet.Cell(row, 4).Value = result.Status;
                row++;
            }

            workbook.SaveAs("ComparisonReport.xlsx");
        }
    }

}
