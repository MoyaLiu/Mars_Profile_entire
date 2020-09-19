using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfileCommon
    {
        public string getAlertDialogText()
        {
            var alertDialogDisplay = By.XPath("//div[@class='ns-box-inner']");
            WebHelper.WaitVisible(Driver.driver, alertDialogDisplay, 2);
            var text = WebHelper.FindElement(Driver.driver, alertDialogDisplay).Text;
            Console.WriteLine("text = " + text);
            return text;
        }
    }
}
