using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.SpecflowPages.Pages.ProfileInfos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.ProfileInfos
{
    [Binding]
    public sealed class EarnTarget_Steps
    {
        EarnTarget target = null;
        ProfileCommon profileCommon = null;

        EarnTarget_Steps()
        {
            target = new EarnTarget();
            profileCommon = new ProfileCommon();
        }

        [Given(@"Click target edit icon")]
        public void GivenClickTargetEditIcon()
        {
            target.ClickEarnTargetWriteIcon();
        }

        [When(@"Choose the target ""(.*)""")]
        public void WhenChooseTheTarget(string earntarget)
        {
            Console.WriteLine("earntarget = " + earntarget);
            target.ChooseEarnTarget(earntarget);
        }

        [Then(@"The Earn Target should be update as ""(.*)""")]
        public void ThenTheEarnTargetShouldBeUpdateAs(string earntarget)
        {
            Console.WriteLine("earntarget = " + earntarget);
            Assert.AreEqual(earntarget, target.getEarnTargetText());
            //Assert.AreEqual(profileInfo.successfulText, profileCommon.getAlertDialogText());
        }

        [When(@"Click target cancel icon")]
        public void WhenClickTargetCancelIcon()
        {
            target.ClickEarnTargetRmIcon();
        }

        [Then(@"The target should not change")]
        public void ThenTheTargetShouldNotChange()
        {
            Assert.AreEqual(target.preTarget, target.getEarnTargetText());
        }
    }
}
