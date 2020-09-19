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
    class TimeType
    {
        public string preTimeType = null;

        private By TimeTypeWrtIcBy = By.XPath("//div[@class= 'ui list']/div[2]/div/span/i[@class='right floated outline small write icon']");
        private By TimeTypeRmIcBy = By.XPath("//div[@class= 'ui list']/div[2]/div/span/i[@class='remove icon']");
        private IWebElement TimeTypeWrtIc => WebHelper.FindElement(Driver.driver, TimeTypeWrtIcBy);
        private IWebElement TimeTypeRmIc => WebHelper.FindElement(Driver.driver, TimeTypeRmIcBy);

        public void ClickTimeTypeWriteIcon()
        {
            WebHelper.WaitClickable(Driver.driver, TimeTypeWrtIcBy, 5);

            //get the previous timetype to assert
            preTimeType = getTimeTypeText();

            TimeTypeWrtIc.Click();
        }
        public void ChooseTimeType(String timeType)
        {
            var timeTypeDropDown = By.XPath("//SELECT[@class= 'ui right labeled dropdown'][@name='availabiltyType']");
            WebHelper.WaitClickable(Driver.driver, timeTypeDropDown, 5);
            WebHelper.FindElement(Driver.driver, timeTypeDropDown).SendKeys(timeType);
        }
        public void ClickTimeTypeRmIcon()
        {
            WebHelper.WaitClickable(Driver.driver, TimeTypeRmIcBy, 5);
            TimeTypeRmIc.Click();
        }
        public String getTimeTypeText()
        {
            var timeTypeDisplay = By.XPath("//div[@class= 'ui list']/div[2]/div");
            //WebHelper.WaitVisible(Driver.driver, timeTypeDisplay, 5);
            Thread.Sleep(3000);
            return WebHelper.FindElement(Driver.driver, timeTypeDisplay).Text;
        }
    }
}
