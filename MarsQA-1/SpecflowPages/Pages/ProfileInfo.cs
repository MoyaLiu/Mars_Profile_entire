using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfileInfo
    {
        private By NameBy = By.XPath("//*[contains(@class,'title')]/i");
        private By FirstNameBy = By.XPath("//INPUT[@type='text'][@name='firstName']");
        private By LastNameBy = By.XPath("//INPUT[@type='text'][@name='lastName']");
        private By NameSaveBy = By.XPath("//BUTTON[@class='ui teal button'][text()='Save']");
        private By TimeTypeWrtIcBy = By.XPath("//div[@class= 'ui list']/div[2]/div/span/i[@class='right floated outline small write icon']");
        private By TimeTypeRmIcBy = By.XPath("//div[@class= 'ui list']/div[2]/div/span/i[@class='remove icon']");
        private By HoursWrtIcBy = By.XPath("//div[@class= 'ui list']/div[3]/div/span/i[@class='right floated outline small write icon']");
        private By HoursRmIcBy = By.XPath("//div[@class= 'ui list']/div[3]/div/span/i[@class='remove icon']");
        private By EarnTargetWrtIcBy = By.XPath("//div[@class= 'ui list']/div[4]/div/span/i[@class='right floated outline small write icon']");
        private By EarnTargetRmIcBy = By.XPath("//div[@class= 'ui list']/div[4]/div/span/i[@class='remove icon']");
        private IWebElement NameBtn => WebHelper.FindElement(Driver.driver, NameBy);
        private IWebElement FirstNameText => WebHelper.FindElement(Driver.driver, FirstNameBy);
        private IWebElement LastNameText => WebHelper.FindElement(Driver.driver,LastNameBy);
        private IWebElement NameSaveBtn => WebHelper.FindElement(Driver.driver, NameSaveBy);
        private IWebElement TimeTypeWrtIc => WebHelper.FindElement(Driver.driver, TimeTypeWrtIcBy);
        private IWebElement TimeTypeRmIc => WebHelper.FindElement(Driver.driver, TimeTypeRmIcBy);
        private IWebElement HoursWrtIc => WebHelper.FindElement(Driver.driver, HoursWrtIcBy);
        private IWebElement HoursRmIc => WebHelper.FindElement(Driver.driver, HoursRmIcBy);
        private IWebElement EarnTargetWrtIc => WebHelper.FindElement(Driver.driver, EarnTargetWrtIcBy);
        private IWebElement EarnTargetRmIc => WebHelper.FindElement(Driver.driver, EarnTargetRmIcBy);
        ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select

        public void ClickName()
        {
            //WebHelper.FindElement(Driver.driver, By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]")).Click();
            //var eName = WebHelper.FindElement(Driver.driver, By.XPath("//div[@class='title']"));//click name
            WebHelper.WaitClickable(Driver.driver, NameBy, 5);
            NameBtn.Click();
        }
        public void EditName(String firstName, String lastName)
        {
            WebHelper.WaitClickable(Driver.driver, FirstNameBy, 5);
            FirstNameText.Click();
            FirstNameText.Clear();
            FirstNameText.SendKeys(firstName);
            WebHelper.WaitClickable(Driver.driver, LastNameBy, 5);
            LastNameText.Click();
            LastNameText.Clear();
            LastNameText.SendKeys(lastName);
            //WebHelper.FindElement(Driver.driver, By.XPath("//INPUT[@type='text'])[@name='firstname']")).SendKeys(firstName);
            //WebHelper.FindElement(Driver.driver, By.XPath("//INPUT[@type='text'])[@name='lastname']")).SendKeys(lastName);
        }
        public void SaveName()
        {
            WebHelper.WaitClickable(Driver.driver, NameSaveBy, 5);
            NameSaveBtn.Click();
            //WebHelper.FindElement(Driver.driver, By.XPath("//BUTTON[@class='ui teal button'][text()='Save']")).Click();
        }

        public string getName()
        {
            var nameText = By.XPath("//div[@class='title']");
            //WebHelper.WaitVisible(Driver.driver, nameText, 15);
            Thread.Sleep(2000);
            return WebHelper.FindElement(Driver.driver, nameText).Text;
        }

        //Availability part
        public void ClickTimeTypeWriteIcon()
        {
            WebHelper.WaitClickable(Driver.driver, TimeTypeWrtIcBy, 5);
            TimeTypeWrtIc.Click();
        }
        public void ChooseTimeType(String timeType)
        {
            var timeTypeDropDown = By.XPath("//SELECT[@class= 'ui right labeled dropdown'][@name='availabiltyType']");
            WebHelper.WaitClickable(Driver.driver, timeTypeDropDown, 5);
            WebHelper.FindElement(Driver.driver, timeTypeDropDown).SendKeys(timeType);
        }
        public String getTimeTypeText()
        {
            var timeTypeDisplay = By.XPath("//div[@class= 'ui list']/div[2]/div");
            //WebHelper.WaitVisible(Driver.driver, timeTypeDisplay, 5);
            Thread.Sleep(3000);
            return WebHelper.FindElement(Driver.driver, timeTypeDisplay).Text;
        }

        //Hours part
        public void ClickHoursWriteIcon()
        {
            WebHelper.WaitClickable(Driver.driver, HoursWrtIcBy, 5);
            HoursWrtIc.Click();
        }
        public void ChooseHours(String hours)
        {
            var hoursDropDown = By.XPath("//SELECT[@class= 'ui right labeled dropdown'][@name='availabiltyHour']");
            WebHelper.WaitClickable(Driver.driver, hoursDropDown, 5);
            WebHelper.FindElement(Driver.driver, hoursDropDown).SendKeys(hours);
        }
        public String getHoursText()
        {
            var hoursDisplay = By.XPath("//div[@class= 'ui list']/div[3]/div");
            //WebHelper.WaitVisible(Driver.driver, timeTypeDisplay, 5);
            Thread.Sleep(2000);
            return WebHelper.FindElement(Driver.driver, hoursDisplay).Text;
        }

        //Earn Target part
        public void ClickEarnTargetWriteIcon()
        {
            WebHelper.WaitClickable(Driver.driver, EarnTargetWrtIcBy, 5);
            EarnTargetWrtIc.Click();
        }
        public void ChooseEarnTarget(String target)
        {
            var targetDropDown = By.XPath("//SELECT[@class= 'ui right labeled dropdown'][@name='availabiltyTarget']");
            WebHelper.WaitClickable(Driver.driver, targetDropDown, 5);
            WebHelper.FindElement(Driver.driver, targetDropDown).SendKeys(target);
        }
        public String getEarnTargetText()
        {
            var targetDisplay = By.XPath("//div[@class= 'ui list']/div[4]/div");
            //WebHelper.WaitVisible(Driver.driver, timeTypeDisplay, 5);
            Thread.Sleep(2000);
            return WebHelper.FindElement(Driver.driver, targetDisplay).Text;
        }
        public String getNsBoxText()
        {
            var nsBoxDisplay = By.XPath("//div[@class='ns-box-inner']");
            WebHelper.WaitVisible(Driver.driver, nsBoxDisplay, 2);
            var text = WebHelper.FindElement(Driver.driver, nsBoxDisplay).Text;
            Console.WriteLine("text = " + text);
            return text;
        }

    }
}
