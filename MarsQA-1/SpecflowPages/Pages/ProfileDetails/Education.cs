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
    class Education
    {
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
        private By AddBtnBy = By.XPath("//input[@class='ui teal button '][@value='Add']");
        private By CancelAddBtnBy = By.XPath("//input[@class='ui button'][@value='Cancel']");
        private By AddNewBtnBy = By.XPath("//div[@class='ui teal button ']");
        private IWebElement eEducation => WebHelper.FindElement(Driver.driver, EducationTitleBy);
    }
}
