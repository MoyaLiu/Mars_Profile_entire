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
    class Certification
    {
        private By CertificationsTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='fourth']");
        private By CertificateEditTextBy = By.XPath("//input[@placeholder='Certificate or Award']");
        private By CertificationFromEditBy = By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']");
        private By CertificationYearDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='certificationYear']");
        private By CertificationWrtIcBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody/tr/td[4]/span[1]/i");
        private By CertificationRmIcBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody/tr/td[4]/span[2]/i");
        private By CertificationUpdateBtnBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[1]/tr/td/div/span//input[@value='Update']");////tbody[i] is row number
        private By CertificationCancelBtnBy = By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[1]/tr/td/div/span//input[@value='Cancel']");
        private By AddBtnBy = By.XPath("//input[@class='ui teal button '][@value='Add']");
        private By CancelAddBtnBy = By.XPath("//input[@class='ui button'][@value='Cancel']");
        private By AddNewBtnBy = By.XPath("//div[@class='ui teal button ']");

        private IWebElement eCertifications => WebHelper.FindElement(Driver.driver, CertificationsTitleBy);
    }
}
