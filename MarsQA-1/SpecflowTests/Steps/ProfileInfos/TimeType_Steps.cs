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
    public sealed class TimeType_Steps
    {
        TimeType timetype = null;
        ProfileCommon profileCommon = null;
        TimeType_Steps()
        {
            timetype = new TimeType();
            profileCommon = new ProfileCommon();
        }

        [Given(@"Click availability edit icon")]
        public void GivenClickAvailabilityEditIcon()
        {
            timetype.ClickTimeTypeWriteIcon();
        }

        [When(@"Choose the availability ""(.*)""")]
        public void WhenChooseTheAvailability(string timeType)
        {
            Console.WriteLine("timeType = " + timeType);
            timetype.ChooseTimeType(timeType);
        }

        [Then(@"The availability should be update as ""(.*)""")]
        public void ThenTheAvailabilityShouldBeUpdateAs(string timeType)
        {
            Console.WriteLine("timeType = " + timeType);
            Assert.AreEqual(timeType, timetype.getTimeTypeText());
            Assert.AreEqual("Availability updated", profileCommon.getAlertDialogText());
        }

        [When(@"Click time type cancel icon")]
        public void WhenClickTimeTypeCancelIcon()
        {
            timetype.ClickTimeTypeRmIcon();
        }
        [Then(@"The timetype should not change")]
        public void ThenTheTimetypeShouldNotChange()
        {
            Console.WriteLine("preTimeType = " + timetype.preTimeType);
            Assert.AreEqual(timetype.preTimeType, timetype.getTimeTypeText());
        }
    }
}