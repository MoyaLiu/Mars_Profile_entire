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
    class Name
    {
        private By NameBy = By.XPath("//*[contains(@class,'title')]/i");
        private By FirstNameBy = By.XPath("//INPUT[@type='text'][@name='firstName']");
        private By LastNameBy = By.XPath("//INPUT[@type='text'][@name='lastName']");
        private By NameSaveBy = By.XPath("//BUTTON[@class='ui teal button'][text()='Save']");
        private IWebElement NameBtn => WebHelper.FindElement(Driver.driver, NameBy);
        private IWebElement FirstNameText => WebHelper.FindElement(Driver.driver, FirstNameBy);
        private IWebElement LastNameText => WebHelper.FindElement(Driver.driver, LastNameBy);
        private IWebElement NameSaveBtn => WebHelper.FindElement(Driver.driver, NameSaveBy);

        public void ClickName()
        {
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
    }
}
