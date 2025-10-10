using ClosedXML.Excel;
using System.Data;

namespace PTS
{
    public static class ExcelYardimcisi
    {
        public static void DataTableIExcelOlarakKaydet(DataTable dataTable, string dosyaYolu)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Veri Sayfası");

                worksheet.Cell("A1").InsertTable(dataTable);

                worksheet.FirstRow().Style.Font.Bold = true;

                worksheet.Columns().AdjustToContents();

                workbook.SaveAs(dosyaYolu);
            }
        }
    }
}