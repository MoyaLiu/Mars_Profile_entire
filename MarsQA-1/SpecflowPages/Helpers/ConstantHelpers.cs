using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";
       
        //ScreenshotPath
        public static string ScreenshotPath = getCodeDirectory() + @"\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = getCodeDirectory() + @"\TestReports\Report.html";

        //ReportXML Path
        public static string ReportXMLPath = getCodeDirectory() + @"\TestReports\XML";

        public static string getCodeDirectory()
        {
            var filepath = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("filepath = " + filepath + @"..\..\");
            return filepath + @"..\..\";
        }
    }
}