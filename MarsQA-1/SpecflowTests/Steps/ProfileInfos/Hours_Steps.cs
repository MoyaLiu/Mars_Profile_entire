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
    public sealed class Hours_Steps
    {
        Hours hours = null;
        ProfileCommon profileCommon = null;
        Hours_Steps()
        {
            hours = new Hours();
            profileCommon = new ProfileCommon();
        }

        [Given(@"Click hours edit icon")]
        public void GivenClickHoursEditIcon()
        {
            hours.ClickHoursWriteIcon();
        }

        [When(@"Choose the hours ""(.*)""")]
        public void WhenChooseTheHours(string inHours)
        {
            Console.WriteLine("inHours = " + inHours);
            hours.ChooseHours(inHours);
        }

        [Then(@"The Hours should be update as ""(.*)""")]
        public void ThenTheHoursShouldBeUpdateAs(string inHours)
        {
            Console.WriteLine("inHours = " + inHours);
            Assert.AreEqual(inHours, hours.getHoursText());
        }

        [When(@"Click hours cancel icon")]
        public void WhenClickHoursCancelIcon()
        {
            hours.ClickHoursRmIcon();
        }
        [Then(@"The hours should not change")]
        public void ThenTheHoursShouldNotChange()
        {
            Console.WriteLine("preHours = " + hours.preHours);
            Assert.AreEqual(hours.preHours, hours.getHoursText());
        }
    }
}
