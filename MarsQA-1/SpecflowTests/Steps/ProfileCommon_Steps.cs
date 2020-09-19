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
    public sealed class ProfileCommon_Steps
    {
        ProfileCommon profileCommon = null;
        ProfileCommon_Steps()
        {
            profileCommon = new ProfileCommon();
        }
        [Then(@"The alert dialog ""(.*)"" should be displayed")]
        public void ThenTheAlertDialogShouldBeDisplayed(string notification)
        {
            StringAssert.Contains(notification, profileCommon.getAlertDialogText());
        }

        [Then(@"The alert dialog should not be displayed")]
        public void ThenTheAlertDialogShouldNotBeDisplayed()
        {
            Assert.IsFalse(profileCommon.isVisibleAlertDialog());
        }
    }
}
