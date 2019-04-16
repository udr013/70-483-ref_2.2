using System;

namespace InteractWithExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the interop
            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            //make the app visible
            excelApp.Visible = true;

            //add a new workbook
            excelApp.Workbooks.Add();

            //obtain the active sheet from the app
            //there is no need to cast this dynamic type
            Microsoft.Office.Interop.Excel.Worksheet worksheet = excelApp.ActiveSheet;

            //Write to celles
            worksheet.Cells[1, "A"] = "Hello";
            worksheet.Cells[2, "B"] = "From me";
            Console.WriteLine("Hello World!");
        }
    }
}
