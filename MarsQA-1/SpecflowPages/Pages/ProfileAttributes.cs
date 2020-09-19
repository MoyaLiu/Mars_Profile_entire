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
    class ProfileAttributes
    {
        private By LanguagesTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='first']");

        private By LanguageAddEditBy = By.XPath("//input[@placeholder='Add Language']");
        private By LanguageLevelDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='level']");
        private By LanguageWrtIcBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");//tbody[i] is row number
        private By LanguageRmIcBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");//td[i] is column number
        private By LanguageUpdateBtnBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Update']");////tbody[i] is row number
        private By LanguageCancelBtnBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Cancel']");

        private By SkillsTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='second']");
        private By SkillAddEditBy = By.XPath("//input[@placeholder='Add Skill']");
        private By SkillLevelDropdownBy = By.XPath("//select[@class ='ui fluid dropdown'][@name='level']");
        private By SkillWrtIcBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        private By SkillRmIcBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");
        private By SkillUpdateBtnBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Update']");////tbody[i] is row number
        private By SkillCancelBtnBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Cancel']");

        private By EducationTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='third']");
        private By EducationCollegeAddEditBy = By.XPath("//input[@placeholder='College/University Name']");
        private By EducationDegreeAddEditBy = By.XPath("//input[@placeholder='Degree']");
        private By EducationCountryDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='country']");
        private By EducationTitleDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='title']");
        private By EducationYearDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='yearOfGraduation']");
        private By EducationWrtIcBy = By.XPath("//div[@data-tab='third']/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i");
        private By EducationRmIcBy = By.XPath("//div[@data-tab='third']/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i");
        private By EducationUpdateBtnBy = By.XPath("//div[@data-tab='third']/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[@value='Update']");////tbody[i] is row number
        private By EducationCancelBtnBy = By.XPath("//div[@data-tab='third']/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[@value='Cancel']");

        private By CertificationsTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='fourth']");
        private By CertificateCerAddEditBy = By.XPath("//input[@placeholder='Certificate or Award']");
        private By CertificationFromEditBy = By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']");
        private By CertificationYearDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='certificationYear']");
        private By CertificationWrtIcBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody/tr/td[4]/span[1]/i");
        private By CertificationRmIcBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody/tr/td[4]/span[2]/i");
        private By CertificationUpdateBtnBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[1]/tr/td/div/span//input[@value='Update']");////tbody[i] is row number
        private By CertificationCancelBtnBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[1]/tr/td/div/span//input[@value='Cancel']");

        private By AddNewBtnBy = By.XPath("//div[@class='ui teal button ']");
        private By AddNewSkillsBtnBy = By.XPath("//div[@class='ui teal button']");

        private By AddLanguageBtnBy = By.XPath("//input[@class='ui teal button'][@value='Add']");
        private By AddBtnBy = By.XPath("//input[@class='ui teal button '][@value='Add']");
        private By CancelButtonBy = By.XPath("//input[@class='ui button'][@value='Cancel']");

        private IWebElement eLanguages => WebHelper.FindElement(Driver.driver, LanguagesTitleBy);
        private IWebElement eLanguageAddEdit => WebHelper.FindElement(Driver.driver, LanguageAddEditBy);
        private IWebElement eLanguageLevelDropdown => WebHelper.FindElement(Driver.driver, LanguageLevelDropdownBy);
        private IWebElement eAddLanguageBtn => WebHelper.FindElement(Driver.driver, AddLanguageBtnBy);
        private IWebElement eLanguageWrtIc => WebHelper.FindElement(Driver.driver, LanguageWrtIcBy);
        private IWebElement eLanguageRmIc => WebHelper.FindElement(Driver.driver, LanguageRmIcBy);
        private IWebElement eLanguageUpdateBtn => WebHelper.FindElement(Driver.driver, LanguageUpdateBtnBy);
        private IWebElement eLanguageCancelBtn => WebHelper.FindElement(Driver.driver, LanguageCancelBtnBy);
        private IWebElement eSkills => WebHelper.FindElement(Driver.driver, SkillsTitleBy);
        private IWebElement eEducation => WebHelper.FindElement(Driver.driver, EducationTitleBy);
        private IWebElement eCertifications => WebHelper.FindElement(Driver.driver, CertificationsTitleBy);
        private IWebElement eAddNewButton => WebHelper.FindElement(Driver.driver, AddNewBtnBy);
        private IWebElement eAddNewSkillButton => WebHelper.FindElement(Driver.driver, AddNewSkillsBtnBy);

        public void ClickLanguageTab()
        {
            WebHelper.WaitClickable(Driver.driver, LanguagesTitleBy, 5);
            eLanguages.Click();
        }

        public void ClickAddNewButton()
        {
            WebHelper.WaitClickable(Driver.driver, AddNewBtnBy, 5);
            eAddNewButton.Click();
        }

        public void EnterLanguageAndLevel(string language, string level)
        {
            Console.WriteLine("language = " + language);
            Console.WriteLine("level = " + level);
            WebHelper.WaitClickable(Driver.driver, LanguageAddEditBy, 5);
            eLanguageAddEdit.Click();
            eLanguageAddEdit.SendKeys(Keys.Control + "a" + Keys.Backspace);
            eLanguageAddEdit.SendKeys(language);
            WebHelper.WaitClickable(Driver.driver, LanguageLevelDropdownBy, 5);
            eLanguageLevelDropdown.Click();
            eLanguageLevelDropdown.SendKeys(level);
        }

        public void ClickAdd()
        {
            WebHelper.WaitClickable(Driver.driver, AddLanguageBtnBy, 5);
            eAddLanguageBtn.Click();
        }
        public void ClickLanguageWrtIc()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageWrtIcBy, 5);
            eLanguageWrtIc.Click();
        }
        public void ClickRemove()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageRmIcBy, 5);
            eLanguageRmIc.Click();
        }
        public void ClickUpdate()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageUpdateBtnBy, 5);
            eLanguageUpdateBtn.Click();
        }
        public void ClickCancel()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageCancelBtnBy, 5);
            eLanguageCancelBtn.Click();
        }

        public string getLanguageText()
        {
            var by = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[1]");
            WebHelper.WaitVisible(Driver.driver, by, 5);
            return WebHelper.FindElement(Driver.driver, by).Text;
        }
        public string getLanguageLevelText()
        {
            var by = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[2]");
            WebHelper.WaitVisible(Driver.driver, by, 5);
            return WebHelper.FindElement(Driver.driver, by).Text;
        }
        public string getAlertDialogText()
        {
            var alertDialogDisplay = By.XPath("//div[@class='ns-box-inner']");
            WebHelper.WaitVisible(Driver.driver, alertDialogDisplay, 2);
            var text = WebHelper.FindElement(Driver.driver, alertDialogDisplay).Text;
            Console.WriteLine("text = " + text);
            return text;
        }
        public bool isVisibleAlertDialog()
        {
            var alertDialogDisplay = By.XPath("//div[@class='ns-box-inner']");
            if (WebHelper.WaitVisible(Driver.driver, alertDialogDisplay, 2))
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
