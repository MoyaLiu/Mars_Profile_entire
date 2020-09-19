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
    class EarnTarget
    {
        public string preTarget = null;
        private By EarnTargetWrtIcBy = By.XPath("//div[@class= 'ui list']/div[4]/div/span/i[@class='right floated outline small write icon']");
        private By EarnTargetRmIcBy = By.XPath("//div[@class= 'ui list']/div[4]/div/span/i[@class='remove icon']");
        private IWebElement EarnTargetWrtIc => WebHelper.FindElement(Driver.driver, EarnTargetWrtIcBy);
        private IWebElement EarnTargetRmIc => WebHelper.FindElement(Driver.driver, EarnTargetRmIcBy);
        public void ClickEarnTargetWriteIcon()
        {
            WebHelper.WaitClickable(Driver.driver, EarnTargetWrtIcBy, 5);
            preTarget = getEarnTargetText();
            EarnTargetWrtIc.Click();
        }
        public void ChooseEarnTarget(String target)
        {
            var targetDropDown = By.XPath("//SELECT[@class= 'ui right labeled dropdown'][@name='availabiltyTarget']");
            WebHelper.WaitClickable(Driver.driver, targetDropDown, 5);
            WebHelper.FindElement(Driver.driver, targetDropDown).SendKeys(target);
        }
        public void ClickEarnTargetRmIcon()
        {
            WebHelper.WaitClickable(Driver.driver, EarnTargetRmIcBy, 5);
            EarnTargetRmIc.Click();
        }
        public String getEarnTargetText()
        {
            var targetDisplay = By.XPath("//div[@class= 'ui list']/div[4]/div");
            //WebHelper.WaitVisible(Driver.driver, timeTypeDisplay, 5);
            Thread.Sleep(2000);
            return WebHelper.FindElement(Driver.driver, targetDisplay).Text;
        }
    }
}
