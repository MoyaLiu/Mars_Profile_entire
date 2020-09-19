using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.ProfileInfos
{
    class Hours
    {
        public string preHours = null;

        private By HoursWrtIcBy = By.XPath("//div[@class= 'ui list']/div[3]/div/span/i[@class='right floated outline small write icon']");
        private By HoursRmIcBy = By.XPath("//div[@class= 'ui list']/div[3]/div/span/i[@class='remove icon']");
        private IWebElement HoursWrtIc => WebHelper.FindElement(Driver.driver, HoursWrtIcBy);
        private IWebElement HoursRmIc => WebHelper.FindElement(Driver.driver, HoursRmIcBy);
        public void ClickHoursWriteIcon()
        {
            WebHelper.WaitClickable(Driver.driver, HoursWrtIcBy, 5);
            preHours = getHoursText();
            HoursWrtIc.Click();
        }
        public void ChooseHours(string hours)
        {
            var hoursDropDown = By.XPath("//SELECT[@class= 'ui right labeled dropdown'][@name='availabiltyHour']");
            WebHelper.WaitClickable(Driver.driver, hoursDropDown, 5);
            WebHelper.FindElement(Driver.driver, hoursDropDown).SendKeys(hours);
        }
        public void ClickHoursRmIcon()
        {
            WebHelper.WaitClickable(Driver.driver, HoursRmIcBy, 5);
            HoursRmIc.Click();
        }
        public string getHoursText()
        {
            var hoursDisplay = By.XPath("//div[@class= 'ui list']/div[3]/div");
            //WebHelper.WaitVisible(Driver.driver, timeTypeDisplay, 5);
            Thread.Sleep(2000);
            return WebHelper.FindElement(Driver.driver, hoursDisplay).Text;
        }
    }
}
