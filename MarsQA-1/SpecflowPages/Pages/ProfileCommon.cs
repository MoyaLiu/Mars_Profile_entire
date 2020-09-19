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
        private By AlertDialogBy = By.XPath("//div[@class='ns-box-inner']");
        public string getAlertDialogText()
        {
            WebHelper.WaitVisible(Driver.driver, AlertDialogBy, 2);
            var text = WebHelper.FindElement(Driver.driver, AlertDialogBy).Text;
            Console.WriteLine("text = " + text);
            return text;
        }
        public bool isVisibleAlertDialog()
        {
            if (WebHelper.WaitVisible(Driver.driver, AlertDialogBy, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
