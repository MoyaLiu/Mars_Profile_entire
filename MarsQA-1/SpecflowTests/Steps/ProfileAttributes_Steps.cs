using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps
{
    [Binding]
    public sealed class ProfileAttributes_Steps
    {
        ProfileAttributes profileAttributes = null;

        ProfileAttributes_Steps()
        {
            profileAttributes = new ProfileAttributes();
        }

        [Given(@"Click Languages Tab")]
        public void GivenClickLanguagesTab()
        {
            profileAttributes.ClickLanguageTab();
        }


        [Given(@"Click Add New button")]
        public void GivenClickAddNewButton()
        {
            profileAttributes.ClickAddNewButton();
        }

        [Given(@"Enter the ""(.*)"" and ""(.*)""")]
        public void GivenEnterTheAnd(string language, string level)
        {
            profileAttributes.EnterLanguageAndLevel(language, level);
        }

        [When(@"Click Add")]
        public void WhenClickAdd()
        {
            profileAttributes.ClickAdd();
        }

        //[Then(@"The ""(.*)"" and ""(.*)"" should be displayed")]
        //public void ThenTheAndShouldBeDisplayed(string language, string level)
        //{
        //    Assert.AreEqual(language, language + " " +profileAttributes.getLanguageText());
        //    Assert.AreEqual(level, profileAttributes.getLanguageLevelText());
        //}

        [Given(@"Click the language item edit button")]
        public void GivenClickTheLanguageItemEditButton()
        {
            profileAttributes.ClickLanguageWrtIc();
        }

        [When(@"Click update")]
        public void WhenClickUpdate()
        {
            profileAttributes.ClickUpdate();
        }

        [When(@"Click cancel")]
        public void WhenClickCancel()
        {
            profileAttributes.ClickCancel();
        }

        [Given(@"Click the language item delete button")]
        public void GivenClickTheLanguageItemDeleteButton()
        {
            profileAttributes.ClickRemove();
        }

        [Then(@"The alert dialog ""(.*)"" should be displayed")]
        public void ThenTheAlertDialogShouldBeDisplayed(string notification)
        {
            StringAssert.Contains(notification, profileAttributes.getAlertDialogText());
        }

        [Then(@"The alert dialog should not be displayed")]
        public void ThenTheAlertDialogShouldNotBeDisplayed()
        {
            Assert.IsFalse(profileAttributes.isVisibleAlertDialog());
        }


        [Given(@"Enter the ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and ""(.*)""")]
        public void GivenEnterTheAnd(string p0, string p1, string p2, int p3, int p4)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and ""(.*)"" should be displayed")]
        public void ThenTheAndShouldBeDisplayed(string p0, string p1, string p2, int p3, int p4)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Enter the ""(.*)"", ""(.*)"" and ""(.*)""")]
        public void GivenEnterTheAnd(string p0, string p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The Sdf""(.*)""Adobe""(.*)""(.*)"" should be displayed")]
        public void ThenTheSdfAdobeShouldBeDisplayed(string p0, string p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }






    }
}
