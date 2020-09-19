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
    public sealed class ProfileInfo_Steps
    {
        ProfileInfo profileInfo = null;

        ProfileInfo_Steps()
        {
            profileInfo = new ProfileInfo();
        }

        //Name part
        [Given(@"Click Name")]
        public void GivenClickName()
        {
            profileInfo.ClickName();
        }

        [Given(@"Enter values in ""(.*)"" and ""(.*)""")]
        public void GivenEnterValuesInAnd(string firstName, string lastName)
        {
            Console.WriteLine("firstName = " + firstName);
            Console.WriteLine("lastName = " + lastName);
            profileInfo.EditName(firstName, lastName);
        }

        [When(@"Click Save")]
        public void WhenClickSave()
        {
            profileInfo.SaveName();
        }

        [Then(@"The name is display as ""(.*)""""(.*)""")]
        public void ThenTheNameIsDisplayAs(string firstName, string lastName)
        {
            Assert.AreEqual(firstName + " " + lastName, profileInfo.getName());
        }

        //Availability part
        [Given(@"Click availability edit icon")]
        public void GivenClickAvailabilityEditIcon()
        {
            profileInfo.ClickTimeTypeWriteIcon();
        }

        [When(@"Choose the availability ""(.*)""")]
        public void WhenChooseTheAvailability(string timeType)
        {
            Console.WriteLine("timeType = " + timeType);
            profileInfo.ChooseTimeType(timeType);
        }

        [Then(@"The availability should be update as ""(.*)""")]
        public void ThenTheAvailabilityShouldBeUpdateAs(string timeType)
        {
            Console.WriteLine("timeType = " + timeType);
            Assert.AreEqual(timeType, profileInfo.getTimeTypeText());
            Assert.AreEqual(profileInfo.successfulText, profileInfo.getAlertDialogText());
        }

        [When(@"Click time type cancel icon")]
        public void WhenClickTimeTypeCancelIcon()
        {
            profileInfo.ClickTimeTypeRmIcon();
        }
        [Then(@"The timetype should not change")]
        public void ThenTheTimetypeShouldNotChange()
        {
            Console.WriteLine("preTimeType = " + profileInfo.preTimeType);
            Assert.AreEqual(profileInfo.preTimeType, profileInfo.getTimeTypeText());
        }

        //Hours part
        [Given(@"Click hours edit icon")]
        public void GivenClickHoursEditIcon()
        {
            profileInfo.ClickHoursWriteIcon();
        }

        [When(@"Choose the hours ""(.*)""")]
        public void WhenChooseTheHours(string hours)
        {
            Console.WriteLine("timeType = " + hours);
            profileInfo.ChooseHours(hours);
        }

        [Then(@"The Hours should be update as ""(.*)""")]
        public void ThenTheHoursShouldBeUpdateAs(string hours)
        {
            Console.WriteLine("hours = " + hours);
            Assert.AreEqual(hours, profileInfo.getHoursText());
            Assert.AreEqual(profileInfo.successfulText, profileInfo.getAlertDialogText());
        }

        [When(@"Click hours cancel icon")]
        public void WhenClickHoursCancelIcon()
        {
            profileInfo.ClickHoursRmIcon();
        }
        [Then(@"The hours should not change")]
        public void ThenTheHoursShouldNotChange()
        {
            Console.WriteLine("preHours = " + profileInfo.preHours);
            Assert.AreEqual(profileInfo.preHours, profileInfo.getHoursText());
        }

        //Earn Target part
        [Given(@"Click target edit icon")]
        public void GivenClickTargetEditIcon()
        {
            profileInfo.ClickEarnTargetWriteIcon();
        }

        [When(@"Choose the target ""(.*)""")]
        public void WhenChooseTheTarget(string target)
        {
            Console.WriteLine("timeType = " + target);
            profileInfo.ChooseEarnTarget(target);
        }

        [Then(@"The Earn Target should be update as ""(.*)""")]
        public void ThenTheEarnTargetShouldBeUpdateAs(string target)
        {
            Console.WriteLine("target = " + target);
            Assert.AreEqual(target, profileInfo.getEarnTargetText());
            Assert.AreEqual(profileInfo.successfulText, profileInfo.getAlertDialogText());
        }

        [When(@"Click target cancel icon")]
        public void WhenClickTargetCancelIcon()
        {
            profileInfo.ClickEarnTargetRmIcon();
        }

        [Then(@"The target should not change")]
        public void ThenTheTargetShouldNotChange()
        {
            Assert.AreEqual(profileInfo.preTarget, profileInfo.getEarnTargetText());
        }






    }
}
