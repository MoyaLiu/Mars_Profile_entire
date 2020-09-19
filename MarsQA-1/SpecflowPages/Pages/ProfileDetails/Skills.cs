using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.ProfileDetails
{
    class Skills
    {
        private By SkillsTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='second']");
        private By AddNewSkillsBtnBy = By.XPath("//div[@class='ui teal button']");
        private By SkillAddEditTextBy = By.XPath("//input[@placeholder='Add Skill']");
        private By SkillLevelDropdownBy = By.XPath("//select[@class ='ui fluid dropdown'][@name='level']");
        private By SkillWrtIcBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        private By SkillRmIcBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");
        private By SkillUpdateBtnBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Update']");////tbody[i] is row number
        private By SkillCancelBtnBy = By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Cancel']");
        private By AddBtnBy = By.XPath("//input[@class='ui teal button '][@value='Add']");
        private By CancelAddBtnBy = By.XPath("//input[@class='ui button'][@value='Cancel']");
        private IWebElement eSkills => WebHelper.FindElement(Driver.driver, SkillsTitleBy);
        private IWebElement eAddNewSkillButton => WebHelper.FindElement(Driver.driver, AddNewSkillsBtnBy);
    }
}
