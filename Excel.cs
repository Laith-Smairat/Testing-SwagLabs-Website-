using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs2
{
    class Excel
    {

        /* Start Standard User */
        public static void sortingAToZ()
        {

            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H3:H3"];
            cellRange.Value = "Pass";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();

        }



        public static void sortingZToA()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H4:H4"];
            cellRange.Value = "Pass";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();
        }


        public static void sortingLowToHigh()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H5:H5"];
            cellRange.Value = "Pass";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();
        }

        public static void sortingHighToLow()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H6:H6"];
            cellRange.Value = "Pass";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();
        }
        /* End Standard User */


        /* Start Problem User */

        public static void sortingAToZWithProblemUser()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H8:H8"];
            cellRange.Value = "Pass";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();

        }


        public static void sortingZToAWithProblemUser()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H9:H9"];
            cellRange.Value = "Fail";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();
        }


        public static void sortingLowToHighWithProblemUser()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H10:H10"];
            cellRange.Value = "Fail";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();
        }

        public static void sortingHighToLowWithProblemUser()
        {
            string filePath = "C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cellRange = ws.Range["H11:H11"];
            cellRange.Value = "Fail";

            wb.SaveAs("C:\\Users\\Laith\\Desktop\\QA Final Project\\Excel\\Automation7.xlsx");
            wb.Close();
        }

        /* End Problem User */
    }
}
